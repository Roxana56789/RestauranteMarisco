using RestauranteMariscos.Entidades;

namespace RestauranteMariscos.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<Categoria> CrearAsync(Categoria categoria);
        Task<Categoria?> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Categoria>> ObtenerTodosAsync();
        Task<Categoria?> ActualizarAsync(Categoria categoria);
        Task<bool> EliminarAsync(int id);
    }
}
