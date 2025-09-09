using Microsoft.AspNetCore.Mvc;

namespace RestauranteMariscos.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
