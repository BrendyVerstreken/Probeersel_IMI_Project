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
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorService _directorService;

        public DirectorsController(IDirectorService directorService)
        {
            _directorService = directorService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var directors = await _directorService.ListAllAsync();
            return Ok(directors);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var directors = await _directorService.GetByIdAsync(id);
            if (directors == null)
            {
                return NotFound($"Director with ID {id} does not exist");
            }

            return Ok(directors);
        }

        [HttpPost]
        public async Task<IActionResult> Post(DirectorRequestDto directorRequestDto)
        {
            var directorResponseDto = await _directorService.AddAsync(directorRequestDto);
            return CreatedAtAction(nameof(Get), new { id = directorResponseDto.Id }, directorResponseDto);
        }

        [HttpPut]
        public async Task<IActionResult> Put(DirectorRequestDto directorRequestDto)
        {
            var directorResponseDto = await _directorService.UpdateAsync(directorRequestDto);

            return Ok(directorResponseDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var artist = _directorService.GetByIdAsync(id);

            if (artist == null)
            {
                return NotFound($"The Director with ID {id} does not exist");
            }

            await _directorService.DeleteAsync(id);

            return Ok();
        }
    }
}
