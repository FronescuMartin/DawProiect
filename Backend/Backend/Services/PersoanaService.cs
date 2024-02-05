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

        public async Task<GetPersoanaDTO> CreatePersoanaAsync(PostPersoanaDTO p)
        {
            var persoana = new Persoana
            {
                Nume = p.Nume,
                Data_nasterii = p.Data_nasterii,
                TaraId = p.TaraId
            };
            await _persoanaRepository.AddAsync(persoana);
            return new GetPersoanaDTO
            {
                Id = persoana.Id,
                Nume = persoana.Nume,
                Data_nasterii = persoana.Data_nasterii,
                TaraId = persoana.TaraId
            };
        }

        public async Task<bool> UpdatePersoanaAsync(int id, PostPersoanaDTO p)
        {
            var persoana = await _persoanaRepository.GetByIdAsync(id);
            if (persoana == null)
            {
                return false;
            }

            persoana.Nume = p.Nume;
            persoana.Data_nasterii = p.Data_nasterii;
            persoana.TaraId = p.TaraId;

            await _persoanaRepository.UpdateAsync(persoana);
            return true;
        }

        public async Task<bool> DeletePersoanaAsync(int id)
        {
            var persoana = await _persoanaRepository.GetByIdAsync(id);
            if (persoana == null)
            {
                return false;
            }
            await _persoanaRepository.DeleteAsync(persoana);
            return true;
        }
    }
}
