using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaBLL.Interfaces.IEFServices;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoMapper;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class UserRegisterService : IUserService
    {
        private readonly IEFUnitOfWork _eFUnitOfWork;
        private readonly IMapper _mapper;

        public UserRegisterService(IEFUnitOfWork eFUnitOfWork, IMapper mapper)
        {
            _eFUnitOfWork = eFUnitOfWork;
            _mapper = mapper;
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
    }
}
