namespace RestauranteMariscos.DTOs.UsuarioDTOs
{
    public class PedidoDto
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaPedido { get; set; }
        public string Estado { get; set; }
    }
}
