using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoDetailsFirmaBLL.DTO;
using AutoDetailsFirmaDAL.Interfaces.EFInterfaces.IEFServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoDetailsFirmaAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProviderController : Controller
    {
        IEFProviderService _iEFProviderService;
        public ProviderController(IEFProviderService iEFProviderService)
        {
            _iEFProviderService = iEFProviderService;
        }
        [HttpGet]
        public IActionResult GetProviderView()
        {

            return View();

        }
        //GET
        [HttpGet("paged")]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _iEFProviderService.GetProviders());
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
                return Ok(await _iEFProviderService.GetProvidersById(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        //POST
        public async Task<IActionResult> Post([FromBody]ProviderDTO value)
        {
            try
            {
                return Ok(await _iEFProviderService.AddProviders(value));
                 
            }
            catch
            {
                return StatusCode(404);
            }
        }

        //PUT
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]ProviderDTO value)
        {
            try
            {
                await _iEFProviderService.UpdateProviders(value);
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
                await _iEFProviderService.DeleteProviders(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
