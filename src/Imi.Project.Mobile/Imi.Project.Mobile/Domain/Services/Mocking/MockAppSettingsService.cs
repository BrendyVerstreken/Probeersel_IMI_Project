using Imi.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Mocking
{
    public class MockAppSettingsService : IAppSettingsService
    {
        private static AppSettings currentSettings = new AppSettings
        {
            EnableLentOut = true,
            ChangeTheme = true
        };

        public async Task<AppSettings> GetSettings()
        {
            return await Task.FromResult(currentSettings);
        }

        public async Task<bool> SaveSettings(AppSettings settings)
        {
            return await Task.FromResult(true);
        }
    }
}
