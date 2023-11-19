using BackEnd.Fachada.Implementacion;
using BackEnd.Fachada.Interfaz;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IFachada app;
        public LoginController()
        {
            app = new Fachada();
        }

        [HttpGet("LoginCheck/{user}/{pass}")]
        public IActionResult LoginCheck(string user, string pass)
        {
            if (app.LoginCheck(user, pass))
            {
                return Ok("Login Correcto!");
            }
            else
            {
                return BadRequest("Error!");
            }
        }

    }
}

