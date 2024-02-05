using Backend.Entities;
using System.Drawing;

namespace Backend.Repositories
{
    public interface IPersoanaRepository
    {
        public Task<IEnumerable<Persoana>> GetAll();
        public Task<Persoana> GetByIdAsync(int id);
    }
}
