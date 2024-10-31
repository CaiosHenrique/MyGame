using Microsoft.AspNetCore.Mvc;

namespace MyGame.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok("Todos os usuários");
        }
    }
}