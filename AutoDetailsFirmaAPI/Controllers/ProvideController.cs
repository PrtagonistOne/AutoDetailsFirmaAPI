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
    public class ProvideController : Controller
    {
        IEFProvideService _iEFProvideService;
        public ProvideController(IEFProvideService iEFProvideService)
        {
            _iEFProvideService = iEFProvideService;
        }

        //GET
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _iEFProvideService.GetProvides());
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
                return Ok(await _iEFProvideService.GetByIdProvides(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        //POST
        public async Task<IActionResult> Post([FromBody]ProvideDTO value)
        {
            try
            {
                await _iEFProvideService.AddProvides(value);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        //PUT
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]ProvideDTO value)
        {
            try
            {
                await _iEFProvideService.UpdateProvides(value);
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
                await _iEFProvideService.DeleteProvides(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
