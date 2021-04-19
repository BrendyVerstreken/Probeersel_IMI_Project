using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using IImageService = Imi.Project.Api.Core.Interfaces.Services.IImageService;
using Microsoft.AspNetCore.Http;

namespace Imi.Project.Api.Core.Services
{
    public class MovieService : IMovieService
    {
        private readonly IRepository<Movie> _movieRepository;
        private readonly IImageService _imageService;
        private readonly IMapper _mapper;

        public MovieService(IRepository<Movie> movieRepository, IImageService imageService, IMapper mapper)
        {
            _movieRepository = movieRepository;
            _imageService = imageService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MovieResponseDto>> GetByGenreIdAsync(Guid id)
        {
            var result = await _movieRepository
                .GetFiltered(m => m.MovieGenres.Any(mg => mg.GenreId.Equals(id)))
                .Include(m => m.MovieGenres)
                    .ThenInclude(mg => mg.Genre)
                .ToListAsync();

            var dto = _mapper.Map<IEnumerable<MovieResponseDto>>(result);
            return dto;
        }

        public async Task<IEnumerable<MovieResponseDto>> GetByLentoutIdAsync(Guid id)
        {
            var result = await _movieRepository
                .GetFiltered(m => m.MovieLentouts.Any(ml => ml.LentOutId.Equals(id)))
                .Include(m => m.MovieLentouts)
                    .ThenInclude(ml => ml.LentOut)
                .ToListAsync();

            var dto = _mapper.Map<IEnumerable<MovieResponseDto>>(result);
            return dto;
        }
        public async Task<IEnumerable<MovieResponseDto>> ListAllAsync()
        {
            var result = await _movieRepository.GetAllAsync()
                 .Include(a => a.MovieLentouts)
                    .ThenInclude(m => m.LentOut)
                .Include(m => m.MovieGenres)
                    .ThenInclude(m => m.Genre)
                .ToListAsync();
            var dto = _mapper.Map<IEnumerable<MovieResponseDto>>(result);
            return dto;
        }

        public async Task<MovieResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _movieRepository.GetByIdAsync(id);
            var dto = _mapper.Map<MovieResponseDto>(result);
            return dto;
        }



        public async Task<MovieResponseDto> AddAsync(MovieRequestDto movieRequestDto)
        {
            var movieEntity = _mapper.Map<Movie>(movieRequestDto);

            if (movieEntity.Image == null)
            {
                movieEntity.Image = new Uri("https://via.placeholder.com/150/1ED760/ffffff?text=" + movieEntity.Title.Replace(" ", "+"), UriKind.Absolute);
            }

            var result = await _movieRepository.AddAsync(movieEntity);
            var dto = _mapper.Map<MovieResponseDto>(result);
            return dto;
        }

        public async Task<MovieResponseDto> UpdateAsync(MovieRequestDto movieRequestDto)
        {
            var movieEntity = _mapper.Map<Movie>(movieRequestDto);
            var result = await _movieRepository.UpdateAsync(movieEntity);
            var dto = _mapper.Map<MovieResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _movieRepository.DeleteAsync(id);
        }

        public async Task<MovieResponseDto> AddOrUpdateImageAsync(Guid id, IFormFile image)
        {
            var artist = await _movieRepository.GetByIdAsync(id);

            if (artist == null) return null; 
            artist.Image = await _imageService.AddOrUpdateImageAsync<Movie>(id, image); 
            await _movieRepository.UpdateAsync(artist); 
            return await GetByIdAsync(id);
        }
    }
}
