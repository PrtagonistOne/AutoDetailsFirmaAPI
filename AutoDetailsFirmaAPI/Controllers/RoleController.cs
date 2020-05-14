using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaBLL.Interfaces.IEFServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoDetailsFirmaAPI.Controllers
{
    [Route("api/[controller]")]
    public class RoleController : Controller
    {
        private readonly IRoleService _roleService;
        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpPost]
        [Route("CreateRole")]
        public async Task<IActionResult> CreateRole([FromBody] RoleDTO dto)
        {
            return Ok(await _roleService.CreateRole(dto));
        }

        [HttpGet]
        [Route("GetAllRoles")]
        public async Task<IList<string>> GetAllRoles([FromQuery]int id)
        {
            return await _roleService.GetAllRolesByUserID(id);
        }


        [HttpPost]
        [Route("SubmitRole")]
        public async Task SubmitRole([FromQuery]int id, [FromQuery]string role)
        {
            await _roleService.AppointRole(id, role);
        }

    }
}