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
    public class ShopController : Controller
    {
        IEFShopService _iEFShopService;
        public ShopController(IEFShopService eFShopService)
        {
            _iEFShopService = eFShopService;
        }

        //GET
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _iEFShopService.GetAllShops());
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
                return Ok(await _iEFShopService.GetShop(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        //POST
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ShopDTO value)
        {
            
               return Ok(await _iEFShopService.AddShops(value));
            
        }

        //PUT
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]ShopDTO value)
        {
            try
            {
                await _iEFShopService.UpdateShops(value);
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
                await _iEFShopService.DeleteShops(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
