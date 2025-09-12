using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteMariscos.Entidades
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required]
        public decimal Total { get; set; }

        // Relación con Usuario (quién hizo el pedido)
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // Relación con DetallePedido (qué platillos contiene el pedido)
        public ICollection<DetallePedido> DetallesPedido { get; set; }
    }
}
