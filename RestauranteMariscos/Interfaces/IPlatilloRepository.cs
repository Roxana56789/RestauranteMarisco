using RestauranteMariscos.Entidades;

namespace RestauranteMariscos.Interfaces
{
    public interface IPlatilloRepository
    {
        Task<IEnumerable<Platillo>> GetAllAsync();
        Task<Platillo> GetByIdAsync(int id);
        Task<Platillo> CreateAsync(Platillo platillo);
        Task<Platillo> UpdateAsync(Platillo platillo);
        Task<bool> DeleteAsync(int id);
    }

}

