using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestauranteMariscos.Entidades
{
    public class DetallePedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Cantidad { get; set; }

        [Required]
        public decimal PrecioUnitario { get; set; }

        // Relación con Pedido
        [ForeignKey("Pedido")]
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }

        // Relación con Platillo
        [ForeignKey("Platillo")]
        public int PlatilloId { get; set; }
        public Platillo Platillo { get; set; }
    }
}
