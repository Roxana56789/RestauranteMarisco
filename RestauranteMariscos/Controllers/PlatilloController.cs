using Microsoft.AspNetCore.Mvc;

namespace RestauranteMariscos.Controllers
{
    public class PlatilloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
