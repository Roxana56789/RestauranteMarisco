using RestauranteMariscos.Entidades;

namespace RestauranteMariscos.Interfaces
{
    public interface IUsuarioRepository
    {
<<<<<<< HEAD
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task<Usuario> GetByIdAsync(int id);
        Task<Usuario> GetByEmailAsync(string email);
        Task<Usuario> CreateAsync(Usuario usuario);
        Task<Usuario> UpdateAsync(Usuario usuario);
        Task<bool> DeleteAsync(int id);
=======
        Task<Usuario> CrearAsync(Usuario usuario);
        Task<Usuario?> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Usuario>> ObtenerTodosAsync();
        Task<Usuario?> ActualizarAsync(Usuario usuario);
        Task<bool> EliminarAsync(int id);
>>>>>>> 7146aaff183ecd8a0e20871596efa348d3379f9f
    }
}

