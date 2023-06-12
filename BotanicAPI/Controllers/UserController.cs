using BotanicAPI.Entities.Profile;
using BotanicAPI.Models.LoginModel;
using BotanicAPI.Models.Register;
using BotanicAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;

namespace BotanicAPI.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        // GET: UserController/Create
        [HttpPost("user/create")]
        public IActionResult Create([FromBody] UserProfileRegister user)
        {
            try
            {                              
                _userService.CreateAsync(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }

        [HttpPost("user/login")]
        public IActionResult Login([FromBody] Login login) 
        {
            try
            {
                var result = _userService.LoginAsync(login);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("user/profile/create")]
        public IActionResult CreatePrile([FromBody] ProfileEntity profile)
        {
            try
            {
                var result = _userService.CreateProfileAsync(profile);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok();
        }
    }
}
