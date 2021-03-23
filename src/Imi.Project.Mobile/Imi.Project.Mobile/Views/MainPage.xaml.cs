using Imi.Project.Mobile.Views;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Imi.Project.Mobile
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void BtnLabrary_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LabraryPage());
        }

        private async void BtnSetting_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingPage());
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }


}
