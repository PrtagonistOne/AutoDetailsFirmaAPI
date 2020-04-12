using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoDetailsFirmaAPI.Controllers
{
    [Route("api/[controller]")]
    public class GroupOfDetailController : Controller
    {
        IEFGroupOfDetailService _iEFGroupOfDetailService;
        public GroupOfDetailController(IEFGroupOfDetailService iEFGroupOfDetailService)
        {
            _iEFGroupOfDetailService = iEFGroupOfDetailService;
        }

        //GET
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _iEFGroupOfDetailService.GetAllGroupOfDetails());
            }
            catch
            {
                return StatusCode(404);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                return Ok(await _iEFGroupOfDetailService.GetGroupOfDetailsById(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        //POST
        public async Task<IActionResult> Post([FromBody]GroupOfDetailDTO value)
        {
            try
            {
                await _iEFGroupOfDetailService.AddGroupOfDetails(value);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        //PUT
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]GroupOfDetailDTO value)
        {
            try
            {
                await _iEFGroupOfDetailService.UpdateGroupOfDetails(value);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        //DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _iEFGroupOfDetailService.DeleteGroupOfDetails(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }

    }
}
