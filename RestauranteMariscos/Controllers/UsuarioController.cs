using Microsoft.AspNetCore.Mvc;

namespace RestauranteMariscos.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: /Usuario/
        public IActionResult Index()
        {
            // Listar usuarios
            return View();
        }

        // GET: /Usuario/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: /Usuario/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(string nombre, string correo)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo))
            {
                ModelState.AddModelError("", "Todos los campos son obligatorios.");
                return View();
            }

            // Guardar en BD

            return RedirectToAction(nameof(Index));
        }

        // GET: /Usuario/Editar/5
        public IActionResult Editar(int id)
        {
            // Buscar usuario
            return View(/*usuario*/);
        }

        // POST: /Usuario/Editar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, string nombre, string correo)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo))
            {
                ModelState.AddModelError("", "Todos los campos son obligatorios.");
                return View();
            }

            // Actualizar usuario

            return RedirectToAction(nameof(Index));
        }

        // GET: /Usuario/Eliminar/5
        public IActionResult Eliminar(int id)
        {
            // Eliminar usuario
            return RedirectToAction(nameof(Index));
        }
    }
}

