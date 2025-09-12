using RestauranteMariscos.Entidades;

namespace RestauranteMariscos.Interfaces
{
    public interface IPlatilloRepository
    {
        Task<Platillo> CrearAsync(Platillo platillo);
        Task<Platillo?> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Platillo>> ObtenerTodosAsync();
        Task<Platillo?> ActualizarAsync(Platillo platillo);
        Task<bool> EliminarAsync(int id);
    }
}

