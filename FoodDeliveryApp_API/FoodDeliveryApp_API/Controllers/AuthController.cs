using FoodDeliveryApp_API.Models;
using FoodDeliveryApp_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FoodDeliveryApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("/Login")]
        public IActionResult Login([FromBody] LoginViewModel usr)
        {
            if(ModelState.IsValid)
            {
                LoginResponseViewModel response = _authService.Login(usr);
                return Ok(response.Token);
            }
            return BadRequest();
        }
    }
}
