using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using AutoDetailsFirmaDAL.Paging;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        public async Task<IActionResult> Get([FromQuery]GroupOfDetailParameters parameters)
        {
            
                if (!parameters.ValidPriceRange)
                {
                    return BadRequest("Invalid range!");
                }

                return Ok(await _iEFGroupOfDetailService.GetPagedGroupOfDetails(parameters));

        }
         [HttpGet("id/{id}")]
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
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]GroupOfDetailDTO value)
        {
                return Ok(await _iEFGroupOfDetailService.AddGroupOfDetails(value));
          
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
