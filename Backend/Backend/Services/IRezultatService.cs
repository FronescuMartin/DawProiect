using Backend.Entities;
using Backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Services
{
    public interface IRezultatService
    {
        Task<IEnumerable<GetRezultatDTO>> GetRezultateAsync();
        Task<GetRezultatDTO> GetRezultatByIdAsync(int id);
        Task<GetRezultatDTO> CreateRezultatAsync(PostRezultatDTO rezultat);
        Task<bool> UpdateRezultatAsync(int id, PostRezultatDTO rezultat);
        Task<bool> DeleteRezultatAsync(int id);
    }
}
