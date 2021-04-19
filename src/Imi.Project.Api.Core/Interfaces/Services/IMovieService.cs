using Imi.Project.Api.Core.Dtos;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieResponseDto>> ListAllAsync();
        Task<MovieResponseDto> GetByIdAsync(Guid id);
        Task<IEnumerable<MovieResponseDto>> GetByGenreIdAsync(Guid id);
        Task<MovieResponseDto> AddAsync(MovieRequestDto movieRequestDto);
        Task<MovieResponseDto> UpdateAsync(MovieRequestDto movieRequestDto);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<MovieResponseDto>> GetByLentoutIdAsync(Guid id);
        Task<MovieResponseDto> AddOrUpdateImageAsync(Guid id, IFormFile image);
    }
}
