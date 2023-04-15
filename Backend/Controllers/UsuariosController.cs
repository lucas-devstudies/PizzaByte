using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{

    [Route("[controller]")]
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Listando usuários");
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok("Listando somente o usuário: " + id);
        }

        [HttpPost]
        public IActionResult CreateUsuarios([FromBody] Usuarios usuarios)
        {
            return Ok("Criando Usuário");
        }

        [HttpPut("{id}")] //revisar porque não sabemos o que deve mudar
        public IActionResult UpdateUsuario(int id)
        {
            return Ok("Atualizando usuário");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuarios(int id)
        {
            return Ok("Deletando um Usuário");
        }
    }
}
