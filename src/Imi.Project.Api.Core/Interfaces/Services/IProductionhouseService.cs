using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Imi.Project.Api.Core.Dtos;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IProductionhouseService
    {
        Task<IEnumerable<ProductionHouseResponseDto>> ListAllAsync();
        Task<ProductionHouseResponseDto> GetByIdAsync(Guid id);
        Task<ProductionHouseResponseDto> AddAsync(ProductionhouseRequestDto productionhouseRequestDto);
        Task<ProductionHouseResponseDto> UpdateAsync(ProductionhouseRequestDto productionhouseRequestDto);
        Task DeleteAsync(Guid id);
    }
}
