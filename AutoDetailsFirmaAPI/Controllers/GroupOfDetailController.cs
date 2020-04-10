using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoDetailsFirmaDAL.EF;
using AutoDetailsFirmaDAL.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutoDetailsFirmaAPI.Controllers
{
    [Route("api/[controller]")]
    public class GroupOfDetailController : Controller
    {
        AutoDetailContext _autoContext;
        public GroupOfDetailController(AutoDetailContext autoService)
        {
            _autoContext = autoService;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<GroupOfDetail> Get()
        {
            return _autoContext.Set<GroupOfDetail>().ToList();
        }


    }
}
