using Microsoft.AspNetCore.Mvc;

namespace RestauranteMariscos.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
