using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestauranteMariscos.Entidades
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        // Relación con Usuarios (un rol puede tener muchos usuarios)
        public ICollection<Usuario> Usuarios { get; set; }
    }
}

