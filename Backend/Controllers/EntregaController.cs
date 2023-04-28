using Backend.Models;
using Backend.Services.Entrega;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntregaController : Controller
    {
        public readonly EntregaService entregaService;
       

        public EntregaController(EntregaService entregaService)
        {
            this.entregaService = entregaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(entregaService.GetAll());
        }

        [HttpGet("{IdEntrega}")]
        public IActionResult GetOne(int IdEntrega)
        {
            var entrega = entregaService.GetOne(IdEntrega);
            if (entrega == null)
            {
                return NotFound();
            }
            return Ok(entrega);
        }

        [HttpPost]
        public IActionResult CreateEntrega(Entrega entrega)
        {
            try
            {
                entregaService.Create(entrega);
                return Ok(entrega);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{IdEntrega}")]
        public IActionResult UpdateEntrega(int IdEntrega, Entrega entrega)
        {
            try
            {
                entregaService.Update(IdEntrega, entrega);
                return Ok(entrega);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{IdEntrega}")]
        public IActionResult DeleteEntrega(int IdEntrega)
        {
            try
            {
                entregaService.Delete(IdEntrega);
                return Ok(IdEntrega);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}