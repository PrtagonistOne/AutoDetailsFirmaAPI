using AutoDetailsFirmaBLL.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Interfaces.IEFServices
{
    public interface IRoleService
    {
        Task<string> CreateRole(RoleDTO role);
        Task AppointRole(int id, string role);
        Task<IList<string>> GetAllRolesByUserID(int id);
    }
}
