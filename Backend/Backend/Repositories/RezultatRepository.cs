using Backend.ContextModels;
using Backend.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class RezultatRepository : IRezultatRepository
    {
        private readonly BackendContext _context;

        public RezultatRepository(BackendContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Rezultat>> GetAllAsync()
        {
            return await _context.Rezultat.Include(r => r.Competitie).Include(r => r.Persoana).ToListAsync();
        }

        public async Task<Rezultat> GetByIdAsync(int id)
        {
            return await _context.Rezultat.FindAsync(id);
        }

        public async Task AddAsync(Rezultat rezultat)
        {
            _context.Rezultat.Add(rezultat);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Rezultat rezultat)
        {
            _context.Entry(rezultat).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Rezultat rezultat)
        {
            _context.Rezultat.Remove(rezultat);
            await _context.SaveChangesAsync();
        }
    }
}