using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaBLL.Interfaces.IEFServices;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class UserService : IUserService
    {
        private readonly IEFUnitOfWork _eFUnitOfWork;

        public UserService(IEFUnitOfWork eFUnitOfWork)
        {
            _eFUnitOfWork = eFUnitOfWork;
        }

        public async Task<string> Register (UserRegisterDTO user)
        {
            if(user.Password != user.PasswordConfirm)
            {
                return "Паролі не співпадають";
            }

            User user1 = new User { Email = user.Email, UserName = user.UserName };
            var result = await _eFUnitOfWork.UserManager.CreateAsync(user1, user.Password);
            if(result.Succeeded)
            {
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
                    return "Вхід успішний!";
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
