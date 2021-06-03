using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Imi.Project.Api.Core.Services
{
    public class GenreService : IGenreService
    {
        private readonly IRepository<Genre> _genreRepository;
        private readonly IMapper _mapper;

        public GenreService(IRepository<Genre> genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        public async Task<GenreResponseDto> AddAsync(GenreRequestDto genreRequestDto)
        {
            var genreEntity = _mapper.Map<Genre>(genreRequestDto);

            var result = await _genreRepository.AddAsync(genreEntity);
            var dto = _mapper.Map<GenreResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _genreRepository.DeleteAsync(id);
        }

        public async Task<GenreResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _genreRepository.GetByIdAsync(id);
            var dto = _mapper.Map<GenreResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<GenreResponseDto>> ListAllAsync()
        {
            var result = await _genreRepository.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<GenreResponseDto>>(result);
            return dto;
        }

        public async Task<GenreResponseDto> UpdateAsync(GenreRequestDto genreRequestDto)
        {
            var genreEntity = _mapper.Map<Genre>(genreRequestDto);
            var result = await _genreRepository.UpdateAsync(genreEntity);
            var dto = _mapper.Map<GenreResponseDto>(result);
            return dto;
        }
    }
}
