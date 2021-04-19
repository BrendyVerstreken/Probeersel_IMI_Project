using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Imi.Project.Api.Core.Dtos;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface ILentOutService
    {
        Task<IEnumerable<LentOutResponseDto>> ListAllAsync();
        Task<LentOutResponseDto> GetByIdAsync(Guid id);
        Task<LentOutResponseDto> AddAsync(LentOutRequestDto lentOutRequestDto);
        Task<LentOutResponseDto> UpdateAsync(LentOutRequestDto lentOutRequestDto);
        Task DeleteAsync(Guid id);
    }
}
