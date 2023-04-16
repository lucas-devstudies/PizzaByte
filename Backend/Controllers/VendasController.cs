using Backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("[controller]")]
    public class VendasController : Controller
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
        public IActionResult Create([FromBody] Vendas venda)
        {
            return Ok("Create");
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Vendas venda)
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