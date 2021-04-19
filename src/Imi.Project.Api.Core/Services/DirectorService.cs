using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class DirectorService : IDirectorService
    {
        private readonly IRepository<Director> _directorRepository;
        private readonly IMapper _mapper;

        public DirectorService(IRepository<Director> directorRepository, IMapper mapper)
        {
            _directorRepository = directorRepository;
            _mapper = mapper;
        }

        public async Task<DirectorResponseDto> AddAsync(DirectorRequestDto directorRequestDto)
        {
            var directorEntity = _mapper.Map<Director>(directorRequestDto);
            var result = await _directorRepository.AddAsync(directorEntity);
            var dto = _mapper.Map<DirectorResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _directorRepository.DeleteAsync(id);
        }

        public async Task<DirectorResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _directorRepository.GetByIdAsync(id);
            var dto = _mapper.Map<DirectorResponseDto>(result);
            return dto;
        }

        public async Task<IEnumerable<DirectorResponseDto>> ListAllAsync()
        {
            var result = await _directorRepository.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<DirectorResponseDto>>(result);
            return dto;
        }

        public async Task<DirectorResponseDto> UpdateAsync(DirectorRequestDto directorRequestDto)
        {
            var directorEntity = _mapper.Map<Director>(directorRequestDto);
            var result = await _directorRepository.UpdateAsync(directorEntity);
            var dto = _mapper.Map<DirectorResponseDto>(result);
            return dto;
        }
    }
}
