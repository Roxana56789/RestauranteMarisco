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
<<<<<<< HEAD
}
=======
}

>>>>>>> 7146aaff183ecd8a0e20871596efa348d3379f9f
