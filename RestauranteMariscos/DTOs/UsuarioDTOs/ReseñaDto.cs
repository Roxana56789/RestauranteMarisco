namespace RestauranteMariscos.DTOs.UsuarioDTOs
{
    public class ReseñaDto
    {
        public int Id { get; set; }
        public int IdPlatillo { get; set; }
        public int Valoracion { get; set; }
        public string Comentario { get; set; }
    }
}
