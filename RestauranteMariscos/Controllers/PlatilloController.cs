using Microsoft.AspNetCore.Mvc;

namespace RestauranteMariscos.Controllers
{
    public class PlatilloController : Controller
    {
        // GET: /Platillo/
        public IActionResult Index()
        {
            // Listar platillos
            return View();
        }

        // GET: /Platillo/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: /Platillo/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(string nombre, decimal precio)
        {
            if (string.IsNullOrEmpty(nombre) || precio <= 0)
            {
                ModelState.AddModelError("", "Datos inválidos.");
                return View();
            }

            // Guardar en BD

            return RedirectToAction(nameof(Index));
        }

        // GET: /Platillo/Editar/5
        public IActionResult Editar(int id)
        {
            // Buscar platillo
            return View(/*platillo*/);
        }

        // POST: /Platillo/Editar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, string nombre, decimal precio)
        {
            if (string.IsNullOrEmpty(nombre) || precio <= 0)
            {
                ModelState.AddModelError("", "Datos inválidos.");
                return View();
            }

            // Actualizar platillo

            return RedirectToAction(nameof(Index));
        }

        // GET: /Platillo/Eliminar/5
        public IActionResult Eliminar(int id)
        {
            // Eliminar platillo
            return RedirectToAction(nameof(Index));
        }
    }
}

