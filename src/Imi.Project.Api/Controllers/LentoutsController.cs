using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LentoutsController : ControllerBase
    {
        private readonly ILentOutService _lentoutService;
        private readonly IMovieService _movieService;

        public LentoutsController(ILentOutService lentOutService, IMovieService movieService)
        {
            _lentoutService = lentOutService;
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var lentouts = await _lentoutService.ListAllAsync();
            return Ok(lentouts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var lentouts = await _lentoutService.GetByIdAsync(id);
            if (lentouts == null)
            {
                return NotFound($"LentOut with ID {id} does not exist");
            }

            return Ok(lentouts);
        }

        [HttpPost]
        public async Task<IActionResult> Post(LentOutRequestDto lentOutRequestDto)
        {
            var lentoutResponseDto = await _lentoutService.AddAsync(lentOutRequestDto);
            return CreatedAtAction(nameof(Get), new { id = lentoutResponseDto.Id }, lentoutResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(LentOutRequestDto lentOutRequestDto)
        {
            var lentoutResponseDto = await _lentoutService.UpdateAsync(lentOutRequestDto);

            return Ok(lentoutResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var artist = _lentoutService.GetByIdAsync(id);

            if (artist == null)
            {
                return NotFound($"The lentout with ID {id} does not exist");
            }

            await _lentoutService.DeleteAsync(id);

            return Ok();
        }

        [HttpGet("{id}/movies")]
        public async Task<IActionResult> GetByLentoutId(Guid id)
        {
            var movies = await _movieService.GetByLentoutIdAsync(id);
            if (movies == null)
            {
                return NotFound($"Lentout with ID {id} does not exist");
            }

            return Ok(movies);
        }
    }
}
