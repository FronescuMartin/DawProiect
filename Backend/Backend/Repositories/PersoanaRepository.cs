using Backend.ContextModels;
using Backend.Entities;
using Backend.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repositories
{

    public class PersoanaRepository : IPersoanaRepository
    {
        private readonly BackendContext _backendContext;

        public PersoanaRepository(BackendContext backendContext)
        {
            this._backendContext = backendContext;
        }

        public async Task<IEnumerable<Persoana>> GetAll()
        {
            return await _backendContext.Persoana.ToListAsync();
        }

        public async Task<Persoana> GetByIdAsync(int id)
        {
            return await _backendContext.Persoana.FindAsync(id);
        }

        public async Task AddAsync(Persoana persoana)
        {
            _backendContext.Persoana.Add(persoana);
            await _backendContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Persoana persoana)
        {
            _backendContext.Entry(persoana).State = EntityState.Modified;
            await _backendContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Persoana persoana)
        {
            _backendContext.Persoana.Remove(persoana);
            await _backendContext.SaveChangesAsync();
        }
    }
}
