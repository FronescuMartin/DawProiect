using Backend.ContextModels;
using Backend.Models;
using Backend.Repositories;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersoanaController : ControllerBase
    {
        private readonly BackendContext _backendContext;
        private readonly IPersoanaRepository _repository;
        private readonly IPersoanaService _service;

        public PersoanaController(BackendContext backendContext, IPersoanaRepository repository, IPersoanaService service)
        {
            _backendContext = backendContext;
            _repository = repository;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetPersoanaDTO>>> IndexAsync()
        {
            var persoane = await _service.GetPersoaneAsync();
            var persoaneDTO = new List<GetPersoanaDTO>();
            foreach (var persoana in persoane)
            {
                var persoanaDTO = new GetPersoanaDTO
                {
                    Id = persoana.Id,
                    Nume = persoana.Nume,
                    Data_nasterii = persoana.Data_nasterii,
                    TaraId = persoana.TaraId
                };
                persoaneDTO.Add(persoanaDTO);
            }
            return persoaneDTO;

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<GetPersoanaDTO>> GetByIdAsync(int id)
        {
            var persoanaDTO = await _service.GetPersoanaByIdAsync(id);
            if (persoanaDTO == null)
            {
                return NotFound();
            }
            return Ok(persoanaDTO);
        }
    }
}
