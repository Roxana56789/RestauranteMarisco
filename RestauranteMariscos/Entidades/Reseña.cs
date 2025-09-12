using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteMariscos.Entidades
{
    public class Reseña
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(500)]
        public string Comentario { get; set; }

        [Range(1, 5)]
        public int Calificacion { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        // Relación con Usuario
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // Relación con Platillo
        [ForeignKey("Platillo")]
        public int PlatilloId { get; set; }
        public Platillo Platillo { get; set; }
    }
}
