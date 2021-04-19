using Imi.Project.Mobile.Domain.Services;
using Imi.Project.Mobile.Domain.Services.Mocking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Imi.Project.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        IAppSettingsService settingsService;
        IUserService usersService;
        public LoginPage()
        {
            InitializeComponent();
            settingsService = new MockAppSettingsService();
            usersService = new MockUsersService();
        }

        protected async override void OnAppearing()
        {
            //get settings and intialize controls
            var settings = await settingsService.GetSettings();

            //get current User and intialize controls
            var currentUser = await usersService.GetUser(settings.CurrentUserId);
            txtUserName.Text = currentUser.UserName;
            txtEmail.Text = currentUser.Email;

            base.OnAppearing();
        }

        private async void BtnSaveSettings_Clicked(object sender, EventArgs e)
        {
            var currentSettings = await settingsService.GetSettings();

            await settingsService.SaveSettings(currentSettings);

            var user = await usersService.GetUser(currentSettings.CurrentUserId);
            user.UserName = txtUserName.Text.Trim();
            user.Email = txtEmail.Text.Trim();
            await usersService.UpdateUser(user);

            await Navigation.PopAsync();
        }
    }
}