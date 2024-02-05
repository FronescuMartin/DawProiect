using Backend.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IRezultatRepository
    {
        Task<IEnumerable<Rezultat>> GetAllAsync();
        Task<Rezultat> GetByIdAsync(int id);
        Task AddAsync(Rezultat rezultat);
        Task UpdateAsync(Rezultat rezultat);
        Task DeleteAsync(Rezultat rezultat);
    }
}