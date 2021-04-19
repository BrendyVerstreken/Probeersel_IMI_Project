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
    public class ProductionhouseService : IProductionhouseService
    {
        private readonly IRepository<Productionhouse> _productionhouseRepository;
        private readonly IMapper _mapper;

        public ProductionhouseService(IRepository<Productionhouse> productionhouseRepository, IMapper mapper)
        {
            _productionhouseRepository = productionhouseRepository;
            _mapper = mapper;
        }

        public async Task<ProductionHouseResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _productionhouseRepository.GetByIdAsync(id);
            var dto = _mapper.Map<ProductionHouseResponseDto>(result);
            return dto;
        }

        public async  Task<IEnumerable<ProductionHouseResponseDto>> ListAllAsync()
        {
            var result = await _productionhouseRepository.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<ProductionHouseResponseDto>>(result);
            return dto;
        }

        public async Task<ProductionHouseResponseDto> AddAsync(ProductionhouseRequestDto productionhouseRequestDto)
        {
            var productionhouseEntity = _mapper.Map<Productionhouse>(productionhouseRequestDto);

            var result = await _productionhouseRepository.AddAsync(productionhouseEntity);
            var dto = _mapper.Map<ProductionHouseResponseDto>(result);
            return dto;
        }

        public async Task<ProductionHouseResponseDto> UpdateAsync(ProductionhouseRequestDto productionhouseRequestDto)
        {
            var productionhouseEntity = _mapper.Map<Productionhouse>(productionhouseRequestDto);
            var result = await _productionhouseRepository.UpdateAsync(productionhouseEntity);
            var dto = _mapper.Map<ProductionHouseResponseDto>(result);
            return dto;
        }

        public async Task DeleteAsync(Guid id)
        {
            await _productionhouseRepository.DeleteAsync(id);
        }
    }
}
