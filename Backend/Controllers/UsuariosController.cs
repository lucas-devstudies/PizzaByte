using Backend.Data;
using Backend.Models;
using Backend.Services.Usuarios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuariosController : Controller
    {
        public readonly UsuariosService usuariosService;

        public UsuariosController(UsuariosService usuariosService)
        {
            this.usuariosService = usuariosService;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(usuariosService.GetAll());
        }

        [HttpGet("{idCliente}")]
        public IActionResult GetOne(int idCliente)
        {
            var usuario = usuariosService.GetOne(idCliente);
            if (usuario == null)
            {
                return NotFound();
            }
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult CreateUsuarios(Usuarios usuario)
        {
            try
            {
                usuariosService.Create(usuario);
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{idCliente}")]
        public IActionResult UpdateUsuario(int idCliente, Usuarios usuario)
        {
            try
            {
                usuariosService.Update(idCliente, usuario);
                return Ok(usuario);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{idCliente}")]
        public IActionResult DeleteUsuarios(int idCliente)
        {
            try
            {
                usuariosService.Delete(idCliente);
                return Ok(idCliente);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
