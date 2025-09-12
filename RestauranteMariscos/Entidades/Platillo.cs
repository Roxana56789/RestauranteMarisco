using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteMariscos.Entidades
{
    public class Platillo
    {
        public Platillo platillo { get; set; }
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Nombre { get; set; }

        [Required]
        public decimal Precio { get; set; }

        public string Descripcion { get; set; }

        // Relación con Categoria
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        
    }
}
    

