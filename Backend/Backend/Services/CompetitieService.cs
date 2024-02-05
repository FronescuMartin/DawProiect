using Backend.Entities;
using Backend.Models;
using Backend.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class CompetitieService : ICompetitieService
    {
        private readonly ICompetitieRepository _competitieRepository;

        public CompetitieService(ICompetitieRepository competitieRepository)
        {
            _competitieRepository = competitieRepository;
        }

        public async Task<IEnumerable<Competitie>> GetCompetitiiAsync()
        {
            var competitii = await _competitieRepository.GetAllAsync();
            return competitii;
        }

        public async Task<GetCompetitieDTO> GetCompetitieByIdAsync(int id)
        {
            var competitie = await _competitieRepository.GetByIdAsync(id);
            if (competitie == null) return null;

            return new GetCompetitieDTO
            {
                Id = competitie.Id,
                Nume = competitie.Nume,
                Oras = competitie.Oras,
                Data = competitie.Data,
            };
        }

        public async Task<PostCompetitieDTO> CreateCompetitieAsync(PostCompetitieDTO dto)
        {
            var competitie = new Competitie
            {
                Nume = dto.Nume,
                Oras = dto.Oras,
                Data = dto.Data,
            };
            await _competitieRepository.AddAsync(competitie);
            return dto;
        }

        public async Task<bool> UpdateCompetitieAsync(int id, PostCompetitieDTO dto)
        {
            var competitie = await _competitieRepository.GetByIdAsync(id);
            if (competitie == null) return false;

            competitie.Nume = dto.Nume;
            competitie.Oras = dto.Oras;
            competitie.Data = dto.Data;

            await _competitieRepository.UpdateAsync(competitie);
            return true;
        }

        public async Task<bool> DeleteCompetitieAsync(int id)
        {
            var competitie = await _competitieRepository.GetByIdAsync(id);
            if (competitie == null) return false;

            await _competitieRepository.DeleteAsync(competitie);
            return true;
        }
    }
}