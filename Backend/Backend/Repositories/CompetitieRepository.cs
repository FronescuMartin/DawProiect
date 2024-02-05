using Backend.ContextModels;
using Backend.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class CompetitieRepository : ICompetitieRepository
    {
        private readonly BackendContext _context;

        public CompetitieRepository(BackendContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Competitie>> GetAllAsync()
        {
            return await _context.Competitie.Include(c => c.Rezultate).ToListAsync();
        }

        public async Task<Competitie> GetByIdAsync(int id)
        {
            return await _context.Competitie.FindAsync(id);
        }

        public async Task AddAsync(Competitie competitie)
        {
            _context.Competitie.Add(competitie);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Competitie competitie)
        {
            _context.Entry(competitie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Competitie competitie)
        {
            _context.Competitie.Remove(competitie);
            await _context.SaveChangesAsync();
        }
    }
}