using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    public class CarrinhoProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
