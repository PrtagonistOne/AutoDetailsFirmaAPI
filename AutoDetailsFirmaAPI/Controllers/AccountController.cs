using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using AutoDetailsFirmaDAL.Entities;
using AutoDetailsFirmaBLL.Interfaces.IEFServices;
using AutoDetailsFirmaBLL.DTO;

namespace AutoDetailsFirmaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDTO user)
        {
            return Ok(await _userService.Register(user));
        }

    }
}