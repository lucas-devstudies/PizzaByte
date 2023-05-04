using Backend.Models;
using Backend.Services.Entregadores;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntregadoresController : Controller
    {
        public readonly EntregadoresService entregadorersService;
        private EntregadoresService entregadoresService;

        public EntregadoresController(EntregadoresService entregadoresService)
        {
            this.entregadoresService = entregadoresService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(entregadoresService.GetAll());
        }

        [HttpGet("{IdEntregadores}")]
        public IActionResult GetOne(int IdEntregadores)
        {
            var entregadores = entregadoresService.GetOne(IdEntregadores);
            if (entregadores == null)
            {
                return NotFound();
            }
            return Ok(entregadores);
        }

        [HttpPost]
        public IActionResult CreateEntregadores(Entregadores entregadores)
        {
            try
            {
                entregadoresService.Create(entregadores);
                return Ok(entregadores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{IdEntregadores}")]
        public IActionResult UpdateEntregadores(int IdEntregadores, Entregadores entregadores)
        {
            try
            {
                entregadoresService.Update(IdEntregadores, entregadores);
                return Ok(entregadores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{IdEntregadores}")]
        public IActionResult DeleteEntregadores(int IdEntregadores)
        {
            try
            {
                entregadoresService.Delete(IdEntregadores);
                return Ok(IdEntregadores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
