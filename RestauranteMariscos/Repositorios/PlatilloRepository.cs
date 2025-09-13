using Microsoft.EntityFrameworkCore;
using RestauranteMariscos.Data;
using RestauranteMariscos.Entidades;
using System;

namespace RestauranteMariscos.Repositories
{
    public class PlatilloRepository
    {
        private readonly AppDbContext _context;

        public PlatilloRepository(AppDbContext context)
        {
            _context = context;
        }

        // ✅ Obtener todos los platillos con su categoría
        public async Task<IEnumerable<Platillo>> GetAllAsync()
        {
            return await _context.Platillos
                .Include(p => p.Categoria)
                .ToListAsync();
        }

        // ✅ Obtener un platillo por Id
        public async Task<Platillo> GetByIdAsync(int id)
        {
            return await _context.Platillos
                .Include(p => p.Categoria)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        // ✅ Crear un platillo
        public async Task<Platillo> CreateAsync(Platillo platillo)
        {
            _context.Platillos.Add(platillo);
            await _context.SaveChangesAsync();
            return platillo;
        }

        // ✅ Actualizar un platillo
        public async Task<Platillo> UpdateAsync(Platillo platillo)
        {
            _context.Platillos.Update(platillo);
            await _context.SaveChangesAsync();
            return platillo;
        }

        // ✅ Eliminar un platillo
        public async Task<bool> DeleteAsync(int id)
        {
            var platillo = await _context.Platillos.FindAsync(id);
            if (platillo == null)
                return false;

            _context.Platillos.Remove(platillo);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}

