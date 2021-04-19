using Imi.Project.Mobile.Domain.Models;
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
    public partial class InfoPage : ContentPage
    {
        private readonly IMovieService movieService;
        private readonly IAppSettingsService settingsService;
        private Movie currentMovie;
        private AppSettings settings;
        private bool isNew = true;

        public InfoPage(Movie movie)
        {
            InitializeComponent();
            settingsService = new MockAppSettingsService();
            movieService = new MockMovieService();

            if (movie == null)
            {
                currentMovie = new Movie();
                Title = "New movie!";
            }
            else
            {
                isNew = false;
                currentMovie = movie;
                Title = currentMovie.Title;
            }

        }

        protected async override void OnAppearing()
        {
            settings = await settingsService.GetSettings();
            LoadMovieState();
            base.OnAppearing();
        }

        private void LoadMovieState()
        {
            txtTitle.Text = currentMovie.Title;
            txtYear.Text = currentMovie.YearOfRelease;
            txtGenre.Text = currentMovie.Genre;
            txtProductionhouse.Text = currentMovie.ProductionHouse;
            txtDescription.Text = currentMovie.Description;
            txtDirector.Text = currentMovie.Director;


        }
    }
}