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

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserRegisterDTO user)
        {
            return Ok(await _userService.Register(user));
        }
        [HttpGet]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginDTO user)
        {
            return Ok(await _userService.Login(user));
        }
        [HttpGet]
        [Route("logout")]
        public async Task<IActionResult> Logout()
        {
            return Ok(await _userService.Logout());
        }
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> Create([FromBody]UserCreateDTO user)
        {
            return Ok(await _userService.Create(user));
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await _userService.Delete(id));
        }
        [HttpPut]
        [Route("edit")]
        public async Task<IActionResult> Edit([FromBody]UserEditDTO user)
        {
            return Ok(await _userService.Edit(user));
        }
        [HttpPut]
        [Route("changePassword")]
        public async Task<IActionResult> ChangePassword([FromBody]UserChangePasswordDTO user)
        {
            return Ok(await _userService.ChangePassword(user));
        }
    }
}