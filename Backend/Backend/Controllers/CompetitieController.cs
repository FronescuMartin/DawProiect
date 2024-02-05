using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitieController : ControllerBase
    {
        private readonly ICompetitieService _service;

        public CompetitieController(ICompetitieService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetCompetitieDTO>>> GetCompetitii()
        {
            var competitii = await _service.GetCompetitiiAsync();
            return Ok(competitii);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetCompetitieDTO>> GetCompetitieById(int id)
        {
            var competitie = await _service.GetCompetitieByIdAsync(id);
            if (competitie == null)
            {
                return NotFound();
            }
            return Ok(competitie);
        }

        [HttpPost]
        public async Task<ActionResult> CreateCompetitie(PostCompetitieDTO competitie)
        {
            var newCompetitie = await _service.CreateCompetitieAsync(competitie);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCompetitie(int id, PostCompetitieDTO competitie)
        {

            var result = await _service.UpdateCompetitieAsync(id, competitie);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetitie(int id)
        {
            var result = await _service.DeleteCompetitieAsync(id);
            if (!result)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}