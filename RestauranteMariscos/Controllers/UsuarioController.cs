using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using RestauranteMariscos.Entidades;
using RestauranteMariscos.Interfaces;

namespace RestauranteMariscos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        // ✅ Obtener todos los usuarios
        [HttpGet]
        [Authorize(Roles = "Admin")] // Solo Admin puede ver todos
        public async Task<ActionResult<IEnumerable<Usuario>>> GetAll()
        {
            var usuarios = await _usuarioRepository.GetAllAsync();
            return Ok(usuarios);
        }

        // ✅ Obtener usuario por Id
        [HttpGet("{id}")]
        [Authorize] // Cualquier usuario autenticado
        public async Task<ActionResult<Usuario>> GetById(int id)
        {
            var usuario = await _usuarioRepository.GetByIdAsync(id);
            if (usuario == null)
                return NotFound(new { message = "Usuario no encontrado" });

            return Ok(usuario);
        }

        // ✅ Crear nuevo usuario
        [HttpPost]
        [Authorize(Roles = "Admin")] // Solo Admin puede crear usuarios
        public async Task<ActionResult<Usuario>> Create([FromBody] Usuario usuario)
        {
            var newUsuario = await _usuarioRepository.CreateAsync(usuario);
            return CreatedAtAction(nameof(GetById), new { id = newUsuario.Id }, newUsuario);
        }

        // ✅ Actualizar usuario
        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")] // Solo Admin puede actualizar
        public async Task<ActionResult<Usuario>> Update(int id, [FromBody] Usuario usuario)
        {
            if (id != usuario.Id)
                return BadRequest(new { message = "El Id no coincide" });

            var updatedUsuario = await _usuarioRepository.UpdateAsync(usuario);
            return Ok(updatedUsuario);
        }

        // ✅ Eliminar usuario
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")] // Solo Admin puede eliminar
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _usuarioRepository.DeleteAsync(id);
            if (!deleted)
                return NotFound(new { message = "Usuario no encontrado" });

            return NoContent();
        }
    }
}

