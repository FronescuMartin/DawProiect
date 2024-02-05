using Backend.Entities;
using Backend.Models;

namespace Backend.Services
{
    public interface IPersoanaService
    {
        public Task<IEnumerable<Persoana>> GetPersoaneAsync();
        public Task<GetPersoanaDTO> GetPersoanaByIdAsync(int id);
        public Task<GetPersoanaDTO> CreatePersoanaAsync(PostPersoanaDTO p);
        public Task<bool> UpdatePersoanaAsync(int id, PostPersoanaDTO p);
        public Task<bool> DeletePersoanaAsync(int id);

    }
}
