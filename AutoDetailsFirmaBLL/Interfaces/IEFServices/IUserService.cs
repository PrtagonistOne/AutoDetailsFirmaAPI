using AutoDetailsFirmaBLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Interfaces.IEFServices
{
    public interface IUserService
    {
        Task<string> Register(UserRegisterDTO dto);
        Task<string> Create(UserCreateDTO dto);
        Task<string> Login(UserLoginDTO dto);
        Task<string> Logout();
        Task<int> Delete(int id);
        Task<string> Edit(UserEditDTO dto);
        Task<string> ChangePassword(UserChangePasswordDTO dto);

    }
}
