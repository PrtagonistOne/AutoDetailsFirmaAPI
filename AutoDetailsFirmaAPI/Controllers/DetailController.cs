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
    [Route("api/[controller]/[action]")]
    public class DetailController : Controller
    {
        IEFDetailService _iEFDetail;
        public DetailController(IEFDetailService eFDetailService)
        {
            _iEFDetail = eFDetailService;
        }

        //GET
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                return Ok(await _iEFDetail.GetAllDetails());
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
                return Ok(await _iEFDetail.GetDetailsById(id));
            }
            catch
            {
                return StatusCode(404);
            }
        }
        //POST
        public async Task<IActionResult> Post([FromBody]DetailDTO value)
        {
            try
            {
                await _iEFDetail.AddDetails(value);
                return StatusCode(201);
            }
            catch
            {
                return StatusCode(404);
            }
        }

        //PUT
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]DetailDTO value)
        {
            try
            {
                await _iEFDetail.UpdateDetails(value);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        //DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult>Delete(int id)
        {
            try
            {
                await _iEFDetail.DeleteDetails(id);
                return StatusCode(204);
            }
            catch
            {
                return StatusCode(404);
            }
        }
        //Get Old and New
        [HttpGet("{car}")]
        public async Task<IActionResult> GetCarByName(string car)
        {
            try
            {
                return Ok(await _iEFDetail.GetCarByName(car));
            }
            catch
            {
                return StatusCode(404);
            }
        }
    }
}
