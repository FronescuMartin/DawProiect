using Backend.Entities;
using Backend.Models;

namespace Backend.Services
{
    public interface IPersoanaService
    {
        public Task<IEnumerable<Persoana>> GetPersoaneAsync();
        public Task<GetPersoanaDTO> GetPersoanaByIdAsync(int id);

    }
}
