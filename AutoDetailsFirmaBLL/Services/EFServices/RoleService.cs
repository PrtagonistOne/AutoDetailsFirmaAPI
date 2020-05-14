using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaBLL.Interfaces.IEFServices;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AutoDetailsFirmaBLL.Services.EFServices
{
    public class RoleService : IRoleService
    {
        private readonly IEFUnitOfWork _eFUnitOfWork;
        private readonly IMapper _mapper;
        public RoleService(IEFUnitOfWork eFUnitOfWork, IMapper mapper)
        {
            _eFUnitOfWork = eFUnitOfWork;
            _mapper = mapper;
        }
        public async Task<string> CreateRole(RoleDTO roleDTO)
        {
            var role = _mapper.Map<RoleDTO, Role>(roleDTO);
            await _eFUnitOfWork.RoleManager.CreateAsync(role);
            return "Роль успішно добавлено!";
        }
        public async Task AppointRole(int id, string role)
        {
            string stringID = Convert.ToString(id);
            User user = await _eFUnitOfWork.UserManager.FindByIdAsync(stringID);
            await _eFUnitOfWork.UserManager.AddToRoleAsync(user, role);
        }
        public async Task<IList<string>> GetAllRolesByUserID(int id)
        {
            string stringID = Convert.ToString(id);
            User user = await _eFUnitOfWork.UserManager.FindByIdAsync(stringID);
            IList<string> userRoles = null;
            if (user != null)
                userRoles = await _eFUnitOfWork.UserManager.GetRolesAsync(user);
            return userRoles;
        }
    }
}
