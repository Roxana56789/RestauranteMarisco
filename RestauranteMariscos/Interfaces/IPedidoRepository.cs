using RestauranteMariscos.Entidades;

namespace RestauranteMariscos.Interfaces
{
    public interface IPedidoRepository
    {
        Task<Pedido> CrearAsync(Pedido pedido);
        Task<Pedido?> ObtenerPorIdAsync(int id);
        Task<IEnumerable<Pedido>> ObtenerTodosAsync();
        Task<Pedido?> ActualizarAsync(Pedido pedido);
        Task<bool> EliminarAsync(int id);
    }
}
