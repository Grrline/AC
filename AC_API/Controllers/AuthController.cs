using AC_Domain.Models;
using AC_Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace AC_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController(AccountService accountService) : Controller
    {
        [HttpPost("register")]
        public IActionResult Register([FromBody]User request)
        {
            accountService.Register(request.Name, request.Surname, request.Password);
            return NoContent(); 
        }

        [HttpPost("login")]
        public IActionResult Login(string name, string surname, string password)
        { 
            var token = accountService.Login(name, surname, password);
            return Ok(token); 
        }
    }
}
