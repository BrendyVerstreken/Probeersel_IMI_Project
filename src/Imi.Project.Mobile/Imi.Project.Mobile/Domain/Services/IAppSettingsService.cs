using Imi.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services
{
    public interface IAppSettingsService
    {
        Task<AppSettings> GetSettings();
        Task<bool> SaveSettings(AppSettings settings);
    }
}
