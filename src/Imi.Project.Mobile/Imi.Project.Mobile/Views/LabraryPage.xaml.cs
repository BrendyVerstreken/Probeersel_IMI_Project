using Imi.Project.Mobile.Domain.Models;
using Imi.Project.Mobile.Domain.Services;
using Imi.Project.Mobile.Domain.Services.Mocking;
using Imi.Project.Mobile.Views;
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
    public partial class LabraryPage : ContentPage
    {
        private readonly IAppSettingsService settingsService;
        private readonly IMovieService moviesService;
        public LabraryPage()
        {
            InitializeComponent();

            settingsService = new MockAppSettingsService();
            moviesService = new MockMovieService();
        }

        protected async override void OnAppearing()
        {
            await RefreshMovieLists();
            base.OnAppearing();
        }

        private async void BtnCreate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CreatePage(null));
        }

        private async void lvLabraryLists_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Movie;
            if (item != null)
            {
                await Navigation.PushAsync(new InfoPage(item));
            }
        }

        private async void MnuLabraryEdit_Clicked(object sender, EventArgs e)
        {
            var selectedMovie = ((MenuItem)sender).CommandParameter as Movie;
            await DisplayAlert("Edit", $"Editing  {selectedMovie.Title}", "OK");
            await Navigation.PushAsync(new InfoPage(selectedMovie));
        }

        private async void MnuLabraryDelete_Clicked(object sender, EventArgs e)
        {
            var selectedMovie = ((MenuItem)sender).CommandParameter as Movie;
            await moviesService.DeleteMovieList(selectedMovie.Id);
            await RefreshMovieLists();
        }

        private async Task RefreshMovieLists()
        {
            //get settings, because we need current user Id
            var settings = await settingsService.GetSettings();
            //get all bucket lists for this user
            var buckets = await moviesService.GetMovieListsForUser(settings.CurrentUserId);
            //bind IEnumerable<Bucket> to the ListView's ItemSource
            lvLabraryLists.ItemsSource = buckets;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}