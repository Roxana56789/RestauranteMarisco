namespace RestauranteMariscos.DTOs.UsuarioDTOs
{
    public class DetallePedidoDto
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdPlatillo { get; set; }
        public int Cantidad { get; set; }
    }
}