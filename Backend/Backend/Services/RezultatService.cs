using Backend.Entities;
using Backend.Models;
using Backend.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Backend.Services
{
    public class RezultatService : IRezultatService
    {
        private readonly IRezultatRepository _rezultatRepository;

        public RezultatService(IRezultatRepository rezultatRepository)
        {
            _rezultatRepository = rezultatRepository;
        }

        public async Task<IEnumerable<GetRezultatDTO>> GetRezultateAsync()
        {
            var rezultate = await _rezultatRepository.GetAllAsync();
            return rezultate.Select(r => new GetRezultatDTO
            {
                Proba = r.Proba,
                Pozitie = r.Pozitie,
                Timp1 = r.Timp1,
                Timp2 = r.Timp2,
                Timp3 = r.Timp3,
                Timp4 = r.Timp4,
                Timp5 = r.Timp5,
                Single = r.Single,
                Average = r.Average,
                CompetitieId = r.CompetitieId,
                PersoanaId = r.PersoanaId
            });
        }

        public async Task<GetRezultatDTO> GetRezultatByIdAsync(int id)
        {
            var r = await _rezultatRepository.GetByIdAsync(id);
            if (r == null) return null;

            return new GetRezultatDTO
            {
                Proba = r.Proba,
                Pozitie = r.Pozitie,
                Timp1 = r.Timp1,
                Timp2 = r.Timp2,
                Timp3 = r.Timp3,
                Timp4 = r.Timp4,
                Timp5 = r.Timp5,
                Single = r.Single,
                Average = r.Average,
                CompetitieId = r.CompetitieId,
                PersoanaId = r.PersoanaId
            };
        }

        public async Task<GetRezultatDTO> CreateRezultatAsync(PostRezultatDTO r)
        {
            var newRezultat = new Rezultat
            {
                Proba = r.Proba,
                Pozitie = r.Pozitie,
                Timp1 = r.Timp1,
                Timp2 = r.Timp2,
                Timp3 = r.Timp3,
                Timp4 = r.Timp4,
                Timp5 = r.Timp5,
                Single = r.Single,
                Average = r.Average,
                CompetitieId = r.CompetitieId,
                PersoanaId = r.PersoanaId
            };

            await _rezultatRepository.AddAsync(newRezultat);

            return new GetRezultatDTO
            {
                Proba = newRezultat.Proba,
                Pozitie = newRezultat.Pozitie,
                Timp1 = newRezultat.Timp1,
                Timp2 = newRezultat.Timp2,
                Timp3 = newRezultat.Timp3,
                Timp4 = newRezultat.Timp4,
                Timp5 = newRezultat.Timp5,
                Single = newRezultat.Single,
                Average = newRezultat.Average,
                CompetitieId = newRezultat.CompetitieId,
                PersoanaId = newRezultat.PersoanaId
            };
        }

        public async Task<bool> UpdateRezultatAsync(int id, PostRezultatDTO updateDto)
        {
            var existingRezultat = await _rezultatRepository.GetByIdAsync(id);
            if (existingRezultat == null) return false;

            await _rezultatRepository.UpdateAsync(existingRezultat);

            return true;
        }

        public async Task<bool> DeleteRezultatAsync(int id)
        {
            var rezultat = await _rezultatRepository.GetByIdAsync(id);
            if (rezultat == null) return false;

            await _rezultatRepository.DeleteAsync(rezultat);
            return true;
        }
    }
}