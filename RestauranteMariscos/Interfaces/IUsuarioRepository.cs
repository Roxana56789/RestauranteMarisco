using RestauranteMariscos.Entidades;

namespace RestauranteMariscos.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<Usuario> CrearAsync(Usuario usuario);
        Task<Usuario?> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Usuario>> ObtenerTodosAsync();
        Task<Usuario?> ActualizarAsync(Usuario usuario);
        Task<bool> EliminarAsync(int id);
    }
}
