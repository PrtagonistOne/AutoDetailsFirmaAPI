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

    }
}
