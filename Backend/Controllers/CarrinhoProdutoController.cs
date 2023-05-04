using Backend.Models;
using Backend.Services.CarrinhoProdutoService;
using Backend.Services.CarrinhoService;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarrinhoProdutoController : Controller
    {
        public readonly CarrinhoProdutoService carrinhoProdutoService;


        public CarrinhoProdutoController(CarrinhoProdutoService carrinhoProdutoService)
        {
            this.carrinhoProdutoService = carrinhoProdutoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(carrinhoProdutoService.GetAll());
        }

        [HttpGet("{IdCarrinhoProduto}")]
        public IActionResult GetOne(int IdCarrinhoProduto)
        {
            var carrinhoProduto = carrinhoProdutoService.GetOne(IdCarrinhoProduto);
            if (carrinhoProduto == null)
            {
                return NotFound();
            }
            return Ok(carrinhoProduto);
        }

        [HttpPost]
        public IActionResult CreateCarrinhoProduto(CarrinhoProduto carrinhoProduto)
        {
            try
            {
                carrinhoProdutoService.Create(carrinhoProduto);
                return Ok(carrinhoProduto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{IdCarrinhoProduto}")]
        public IActionResult Update(int IdCarrinhoProduto, CarrinhoProduto carrinhoProduto)
        {
            try
            {
                carrinhoProdutoService.Update(IdCarrinhoProduto, carrinhoProduto);
                return Ok(carrinhoProduto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{IdCarrinhoProduto}")]
        public IActionResult DeleteCarrinhoProduto(int IdCarrinhoProduto)
        {
            try
            {
                carrinhoProdutoService.Delete(IdCarrinhoProduto);
                return Ok(IdCarrinhoProduto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
