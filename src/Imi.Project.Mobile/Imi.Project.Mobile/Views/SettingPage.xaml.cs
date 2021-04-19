using Imi.Project.Mobile.Domain.Services;
using Imi.Project.Mobile.Domain.Services.Mocking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        IAppSettingsService settingsService;

        public SettingPage()
        {
            InitializeComponent();
            settingsService = new MockAppSettingsService();
        }

        protected async override void OnAppearing()
        {
            var settings = await settingsService.GetSettings();
            swChangTheTheme.On = settings.ChangeTheme;

            base.OnAppearing();
        }

        private async void BtnSaveSettings_Clicked(object sender, EventArgs e)
        {
            var currentSettings = await settingsService.GetSettings();
            currentSettings.ChangeTheme = swChangTheTheme.On;
            await settingsService.SaveSettings(currentSettings);

            await Navigation.PopAsync();
        }

    }
}