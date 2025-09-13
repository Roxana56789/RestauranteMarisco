using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteMariscos.Entidades
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; }

        [Required, MaxLength(150)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        // Relación con Rol
        [ForeignKey("Rol")]
        public int RolId { get; set; }
        public Rol Rol { get; set; }

        // Relación con Pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        // Relación con Reseñas
        public ICollection<Reseña> Reseñas { get; set; }
    }
}
