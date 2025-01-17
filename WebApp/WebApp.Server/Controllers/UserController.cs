using Microsoft.AspNetCore.Mvc;
using WebApp.Service;
using WebApp.Service.DTO;
namespace WebApp.Server.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<ActionResult> AddUser([FromBody] UserDto user)
        {
            try
            {
                await _userService.AddUser(user);

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}