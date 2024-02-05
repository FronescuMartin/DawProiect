using Backend.Entities;
using Backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Services
{
    public interface ICompetitieService
    {
        Task<IEnumerable<Competitie>> GetCompetitiiAsync();
        Task<GetCompetitieDTO> GetCompetitieByIdAsync(int id);
        Task<PostCompetitieDTO> CreateCompetitieAsync(PostCompetitieDTO competitie);
        Task<bool> UpdateCompetitieAsync(int id, PostCompetitieDTO competitie);
        Task<bool> DeleteCompetitieAsync(int id);
    }
}
