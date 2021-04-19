using Imi.Project.Api.Core.Entities.Base;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IImageService
    {
        Task<Uri> AddOrUpdateImageAsync<T>(Guid id, IFormFile image) where T : EntityBase;
    }
}
