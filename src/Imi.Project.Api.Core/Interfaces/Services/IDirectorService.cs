using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IDirectorService
    {
        Task<IEnumerable<DirectorResponseDto>> ListAllAsync();
        Task<DirectorResponseDto> GetByIdAsync(Guid id);
        Task<DirectorResponseDto> AddAsync(DirectorRequestDto directorRequestDto);
        Task<DirectorResponseDto> UpdateAsync(DirectorRequestDto directorRequestDto);
        Task DeleteAsync(Guid id);

    }
}
