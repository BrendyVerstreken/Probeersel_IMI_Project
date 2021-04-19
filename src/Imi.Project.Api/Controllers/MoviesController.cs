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
    public class MoviesController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MoviesController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var movies = await _movieService.ListAllAsync();
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var movie = await _movieService.GetByIdAsync(id);
            if (movie == null)
            {
                return NotFound($"Movie with ID {id} does not exist");
            }

            return Ok(movie);
        }

        [HttpPost]
        public async Task<IActionResult> Post(MovieRequestDto movieRequestDto)
        {
            var movieResponseDto = await _movieService.AddAsync(movieRequestDto);
            return CreatedAtAction(nameof(Get), new { id = movieResponseDto.Id }, movieResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(MovieRequestDto movieRequestDto)
        {
            var movieResponseDto = await _movieService.UpdateAsync(movieRequestDto);

            return Ok(movieResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var artist = _movieService.GetByIdAsync(id);

            if (artist == null)
            {
                return NotFound($"The movie with ID {id} does not exist");
            }

            await _movieService.DeleteAsync(id);

            return Ok();
        }

        [HttpPost("{id}/image"), HttpPut("{id}/image")] 
        public async Task<IActionResult> Image([FromRoute] Guid id, IFormFile image) 
        { 
            var movie = await _movieService.AddOrUpdateImageAsync(id, image); 
            if (movie == null) 
            { 
                return NotFound($"Artist with ID {id} does not exist"); 
            } 
            return Ok(movie); 
        }

    }
}
