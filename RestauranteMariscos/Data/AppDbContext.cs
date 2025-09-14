using Microsoft.EntityFrameworkCore;
using RestauranteMariscos.Entidades;

namespace RestauranteMariscos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Platillo> Platillos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}
