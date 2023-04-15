using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("[controller]")]
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return Ok("GetAll");
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok("GetOne");
        }

        [HttpPost]
        public IActionResult Create([FromBody] Usuarios usuarios)
        {
            return Ok("Create" + usuarios.NomeCliente);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Usuarios usuarios)
        {
            return Ok("Update");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Delete");
        }
    }
}
