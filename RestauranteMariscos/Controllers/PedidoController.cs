using Microsoft.AspNetCore.Mvc;

namespace RestauranteMariscos.Controllers
{
    public class PedidoController : Controller
    {
        // GET: /Pedido/
        public IActionResult Index()
        {
            // Obtener pedidos de BD
            return View();
        }

        // GET: /Pedido/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: /Pedido/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(string descripcion, decimal total)
        {
            if (string.IsNullOrEmpty(descripcion) || total <= 0)
            {
                ModelState.AddModelError("", "Datos inválidos.");
                return View();
            }

            // Guardar en BD

            return RedirectToAction(nameof(Index));
        }

        // GET: /Pedido/Editar/5
        public IActionResult Editar(int id)
        {
            // Buscar pedido
            return View(/*pedido*/);
        }

        // POST: /Pedido/Editar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, string descripcion, decimal total)
        {
            if (string.IsNullOrEmpty(descripcion) || total <= 0)
            {
                ModelState.AddModelError("", "Datos inválidos.");
                return View();
            }

            // Actualizar pedido en BD

            return RedirectToAction(nameof(Index));
        }

        // GET: /Pedido/Eliminar/5
        public IActionResult Eliminar(int id)
        {
            // Eliminar pedido en BD
            return RedirectToAction(nameof(Index));
        }
    }
}

