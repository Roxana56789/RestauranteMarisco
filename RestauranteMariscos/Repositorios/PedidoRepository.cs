using RestauranteMariscos.Entidades;
using System;
using Microsoft.EntityFrameworkCore;
using RestauranteMariscos.Data;
using RestauranteMariscos.Entidades;


namespace RestauranteMariscos.Repositorios
{
    public class PedidoRepository
    {
        private readonly AppDbContext _context;

        public PedidoRepository(AppDbContext context)
        {
            _context = context;
        }

        // ✅ Obtener todos los pedidos con usuario y detalles
        public async Task<IEnumerable<Pedido>> GetAllAsync()
        {
            return await _context.Pedidos
                .Include(p => p.Usuario)
                .Include(p => p.DetallesPedido)
                    .ThenInclude(d => d.Platillo)
                .ToListAsync();
        }

        // ✅ Obtener un pedido por Id
        public async Task<Pedido> GetByIdAsync(int id)
        {
            return await _context.Pedidos
                .Include(p => p.Usuario)
                .Include(p => p.DetallesPedido)
                    .ThenInclude(d => d.Platillo)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        // ✅ Crear un nuevo pedido
        public async Task<Pedido> CreateAsync(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }

        // ✅ Actualizar pedido
        public async Task<Pedido> UpdateAsync(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }

        // ✅ Eliminar pedido
        public async Task<bool> DeleteAsync(int id)
        {
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
                return false;

            _context.Pedidos.Remove(pedido);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
