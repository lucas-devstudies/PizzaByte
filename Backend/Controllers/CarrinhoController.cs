using Backend.Models;
using Backend.Services.CarrinhoService;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarrinhoController : Controller
    {
        public readonly CarrinhoService carrinhoService;


        public CarrinhoController(CarrinhoService carrinhoService)
        {
            this.carrinhoService = carrinhoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(carrinhoService.GetAll());
        }

        [HttpGet("{IdCarrinho}")]
        public IActionResult GetOne(int IdCarrinho)
        {
            var carrinho = carrinhoService.GetOne(IdCarrinho);
            if (carrinho == null)
            {
                return NotFound();
            }
            return Ok(carrinho);
        }

        [HttpPost]
        public IActionResult CreateCarrinho(Carrinho carrinho)
        {
            try
            {
                carrinhoService.Create(carrinho);
                return Ok(carrinho);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{IdCarrinho}")]
        public IActionResult Update(int IdCarrinho, Carrinho carrinho)
        {
            try
            {
                carrinhoService.Update(IdCarrinho, carrinho);
                return Ok(carrinho);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{IdCarrinho}")]
        public IActionResult DeleteCarrinho(int IdCarrinho)
        {
            try
            {
                carrinhoService.Delete(IdCarrinho);
                return Ok(IdCarrinho);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}