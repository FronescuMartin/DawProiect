using Backend.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface ICompetitieRepository
    {
        Task<IEnumerable<Competitie>> GetAllAsync();
        Task<Competitie> GetByIdAsync(int id);
        Task AddAsync(Competitie competitie);
        Task UpdateAsync(Competitie competitie);
        Task DeleteAsync(Competitie competitie);
    }
}