using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaBLL.Interfaces.IEFServices;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class UserService : IUserService
    {
        private readonly IEFUnitOfWork _eFUnitOfWork;
        private readonly IConfiguration _config;

        public UserService(IEFUnitOfWork eFUnitOfWork, IConfiguration config)
        {
            _eFUnitOfWork = eFUnitOfWork;
            _config = config;
        }
       
        private async Task<string> TokenBuild(User user)
        {
            var roles = await _eFUnitOfWork.SignInManager.UserManager.GetRolesAsync(user);
            var claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim("acccontID", user.Id.ToString()));
            claims.Add(new Claim("email", user.Email));

            foreach(var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSecurityKey"]));
            var encode = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expire = DateTime.UtcNow.AddMinutes(double.Parse(_config["JwtExpire"]));

            JwtSecurityToken token = new JwtSecurityToken(
                issuer: _config["JwtIssuer"],
                audience: _config["JwtAudience"],
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: expire,
                signingCredentials: encode
                );


            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        public async Task<string> Register (UserRegisterDTO user)
        {
            if(user.Password != user.PasswordConfirm)
                return "Паролі не співпадають";

            User user1 = new User { Email = user.Email, UserName = user.UserName };
            var result = await _eFUnitOfWork.UserManager.CreateAsync(user1, user.Password);
            if(result.Succeeded)
            {
                await _eFUnitOfWork.UserManager.AddToRoleAsync(user1, "user");
                return "Користувача успішно зареєстровано!";
            }
            else
            {
                string ErrorMessage = " ";
                foreach(var error in result.Errors)
                {
                    ErrorMessage += error.Description + "\n";
                }
                return ErrorMessage;
            }
          
        }

        public async Task<string> Login(UserLoginDTO loginDTO)
        {
            User user = await _eFUnitOfWork.UserManager.FindByNameAsync(loginDTO.UserName);
            if(user!= null)
            {
                var result = await _eFUnitOfWork.SignInManager.PasswordSignInAsync(loginDTO.UserName, loginDTO.Password, loginDTO.RememberMe, false);
                if (result.Succeeded)
                {
                    var tok = await TokenBuild(user);
                    return "Користувача Зареєстровано" + $" \n Token: {tok}";
                }
                else
                {
                    return "Невдалий вхід! (невірний пароль)";
                }
            }
            return "Користувача не знайдено";

        }
        public async Task<string> Logout()
        {
            await _eFUnitOfWork.SignInManager.SignOutAsync();
            return "Вихід успішний!";
        }
        public async Task<string>Create(UserCreateDTO user)
        {
            User user1 = new User { Email = user.Email, UserName = user.UserName, Password = user.Password };
            var result = await _eFUnitOfWork.UserManager.CreateAsync(user1, user.Password);
            if(result.Succeeded)
            {
                await _eFUnitOfWork.SignInManager.SignInAsync(user1, false);
                return "Користувача зареєстровано";
            }
            else
            {
                string ErrorMessage = "";
                foreach(var error in result.Errors)
                {
                    ErrorMessage += error.Description + "\n";
                }
                return ErrorMessage;
            }

        }
        public async Task<int> Delete(int id)
        {
            string stringId = Convert.ToString(id);
            User user = await _eFUnitOfWork.UserManager.FindByIdAsync(stringId);
            if (user != null)
            {
                await _eFUnitOfWork.UserManager.DeleteAsync(user);
                return 200;
            }
            else
            {
                return 404;
            }
        }
        public async Task<string>Edit(UserEditDTO editDTO)
        {
            User user = await _eFUnitOfWork.UserManager.FindByIdAsync(Convert.ToString(editDTO.Id));
            if (user != null)
            {
                user.Email = editDTO.Email;
                user.UserName = editDTO.UserName;

                var result = await _eFUnitOfWork.UserManager.UpdateAsync(user);

                if (result.Succeeded)
                { return "Данні користувача успішно змінені!"; }
                else
                {
                    string ErrorMessage = "";
                    foreach (var error in result.Errors)
                    { ErrorMessage += error.Description + "\n"; }
                    return ErrorMessage;
                }
            }
            return "Користувача не існує!";

        }
        public async Task<string>ChangePassword(UserChangePasswordDTO userChange)
        {
            User user = await _eFUnitOfWork.UserManager.FindByIdAsync(Convert.ToString(userChange.Id));
            if (user != null)
            {
                var result =
                     await _eFUnitOfWork.UserManager.ChangePasswordAsync(user, userChange.OldPassword, userChange.NewPassword);
                if (result.Succeeded)
                {
                    user.Password = userChange.NewPassword;
                    return "Пароль успішно змінено!";
                }
                else
                {
                   
                    string ErrorMessage = "";
                    foreach (var error in result.Errors)
                    {
                        ErrorMessage += error.Description + "\n"; 
                    }
                    return ErrorMessage;
                    
                }
            }
            
            return "Користувача не існує!";
        }

    }
}
