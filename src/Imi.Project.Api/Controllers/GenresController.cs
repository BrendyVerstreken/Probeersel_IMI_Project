﻿using Imi.Project.Api.Core.Dtos;
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
    public class GenresController : ControllerBase
    {
        private readonly IGenreService _genreService;
        private readonly IMovieService _movieService;

        public GenresController(IGenreService genreService, IMovieService movieService)
        {
            _genreService = genreService;
            _movieService = movieService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var genres = await _genreService.ListAllAsync();

            return Ok(genres);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var genre = await _genreService.GetByIdAsync(id);
            if (genre == null)
            {
                return NotFound($"Genre with ID {id} does not exist");
            }

            return Ok(genre);
        }

        [HttpGet("{id}/movies")]
        public async Task<IActionResult> GetByGenreId(Guid id)
        {
            var movies = await _movieService.GetByGenreIdAsync(id);
            if (movies == null)
            {
                return NotFound($"Genre with ID {id} does not exist");
            }

            return Ok(movies);
        }

        [HttpPost]
        public async Task<IActionResult> Post(GenreRequestDto genreRequestDto)
        {
            var genreResponseDto = await _genreService.AddAsync(genreRequestDto);
            return CreatedAtAction(nameof(Get), new { id = genreResponseDto.Id }, genreResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(GenreRequestDto genreRequestDto)
        {
            var genreResponseDto = await _genreService.UpdateAsync(genreRequestDto);

            return Ok(genreResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var artist = _genreService.GetByIdAsync(id);

            if (artist == null)
            {
                return NotFound($"Genres with ID {id} does not exist");
            }

            await _genreService.DeleteAsync(id);

            return Ok();
        }
    }
}
