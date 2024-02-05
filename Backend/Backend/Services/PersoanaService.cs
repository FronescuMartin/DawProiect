using Backend.Entities;
using Backend.Models;
using Backend.Repositories;

namespace Backend.Services
{
    public class PersoanaService : IPersoanaService
    {
        private readonly IPersoanaRepository _persoanaRepository;

        public PersoanaService(IPersoanaRepository persoanaRepository)
        {
            _persoanaRepository = persoanaRepository;
        }
        public async Task<IEnumerable<Persoana>> GetPersoaneAsync()
        {
            return await _persoanaRepository.GetAll();
        }

        public async Task<GetPersoanaDTO> GetPersoanaByIdAsync(int id)
        {
            var persoana = await _persoanaRepository.GetByIdAsync(id);
            if (persoana == null)
            {
                return null;
            }
            var persoanaDTO = new GetPersoanaDTO
            {
                Id = persoana.Id,
                Nume = persoana.Nume,
                Data_nasterii = persoana.Data_nasterii,
                TaraId = persoana.TaraId
            };
            return persoanaDTO;
        }
    }
}
