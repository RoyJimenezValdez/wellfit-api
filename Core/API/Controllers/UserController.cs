using Microsoft.AspNetCore.Mvc;
using wellfit_api.Models;
using wellfit_api.DTOs;
using wellfit_api.Interfaces;

namespace wellfit_api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] UserCreateDto newUser)
        {
            var user = new User
            {
                Username = newUser.Username,
                Email = newUser.Email
            };

            var createUser = _userService.CreateUser(user);
            return CreatedAtAction(nameof(CreateUser), createUser);
        }

    }
}