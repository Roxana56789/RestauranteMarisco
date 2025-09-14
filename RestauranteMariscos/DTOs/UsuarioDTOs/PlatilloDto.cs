namespace RestauranteMariscos.DTOs.UsuarioDTOs
{
    public class PlatilloDto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
    }
}
