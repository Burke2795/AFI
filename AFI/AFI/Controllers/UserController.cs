using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AFI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserModel model)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _userService.CreateUser(model));
            }

            return BadRequest(model);
        }
    }
}
