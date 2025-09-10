using Microsoft.AspNetCore.Mvc;

namespace RestauranteMariscos.Controllers
{
    
    public class CategoriaController : Controller
    {
        // GET: /Categoria/
        public IActionResult Index()
        {
            // Aquí deberías obtener todas las categorías desde la BD
            return View();
        }

        // GET: /Categoria/Crear
        public IActionResult Crear()
        {
            return View();
        }

        // POST: /Categoria/Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                ModelState.AddModelError("", "El nombre es obligatorio.");
                return View();
            }

            // Guardar en BD (ejemplo con EF: _context.Categorias.Add(new Categoria { Nombre = nombre }); _context.SaveChanges();)

            return RedirectToAction(nameof(Index));
        }

        // GET: /Categoria/Editar/5
        public IActionResult Editar(int id)
        {
            // Buscar categoría por ID en BD
            return View(/*categoria*/);
        }

        // POST: /Categoria/Editar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(int id, string nombre)
        {
            if (string.IsNullOrEmpty(nombre))
            {
                ModelState.AddModelError("", "El nombre es obligatorio.");
                return View();
            }

            // Actualizar en BD

            return RedirectToAction(nameof(Index));
        }

        // GET: /Categoria/Eliminar/5
        public IActionResult Eliminar(int id)
        {
            // Eliminar de BD
            return RedirectToAction(nameof(Index));
        }
    }
} 


  