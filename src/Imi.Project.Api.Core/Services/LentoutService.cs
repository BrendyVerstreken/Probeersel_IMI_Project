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
    public class LentoutService : ILentOutService
    {
        private readonly IRepository<LentOut> _lentoutRepository;
        private readonly IMapper _mapper;

        public LentoutService(IRepository<LentOut> lentourRepository, IMapper mapper)
        {
            _lentoutRepository = lentourRepository;
            _mapper = mapper;
        }

        public async Task<LentOutResponseDto> AddAsync(LentOutRequestDto lentOutRequestDto)
        {
            var lentoutEntity = _mapper.Map<LentOut>(lentOutRequestDto);
            var result = await _lentoutRepository.AddAsync(lentoutEntity);
            var dto = _mapper.Map<LentOutResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _lentoutRepository.DeleteAsync(id);
        }

        public async Task<LentOutResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _lentoutRepository.GetByIdAsync(id);
            var dto = _mapper.Map<LentOutResponseDto>(result);
            return dto;
        }

        public async  Task<IEnumerable<LentOutResponseDto>> ListAllAsync()
        {
            var result = await _lentoutRepository.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<LentOutResponseDto>>(result);
            return dto;
        }

        public async Task<LentOutResponseDto> UpdateAsync(LentOutRequestDto lentOutRequestDto)
        {
            var lentoutEntity = _mapper.Map<LentOut>(lentOutRequestDto);
            var result = await _lentoutRepository.UpdateAsync(lentoutEntity);
            var dto = _mapper.Map<LentOutResponseDto>(result);
            return dto;
        }
    }
}
