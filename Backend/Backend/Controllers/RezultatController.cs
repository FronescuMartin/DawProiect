using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RezultatController : ControllerBase
    {
        private readonly IRezultatService _rezultatService;

        public RezultatController(IRezultatService rezultatService)
        {
            _rezultatService = rezultatService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetRezultatDTO>>> GetAll()
        {
            var rezultate = await _rezultatService.GetRezultateAsync();
            return Ok(rezultate);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetRezultatDTO>> GetById(int id)
        {
            var rezultat = await _rezultatService.GetRezultatByIdAsync(id);
            if (rezultat == null) return NotFound();
            return Ok(rezultat);
        }

        [HttpPost]
        public async Task<ActionResult> Create(PostRezultatDTO createDto)
        {
            await _rezultatService.CreateRezultatAsync(createDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, PostRezultatDTO updateDto)
        {
            var result = await _rezultatService.UpdateRezultatAsync(id, updateDto);
            if (!result) return NotFound();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _rezultatService.DeleteRezultatAsync(id);
            if (!result) return NotFound();
            return Ok();
        }
    }
}