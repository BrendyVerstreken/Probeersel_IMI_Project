using Imi.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services.Mocking
{
    public class MockMovieService : IMovieService
    {
        private static List<Movie> movieList = new List<Movie>
        {
            new Movie
            {
                Id = Guid.Parse("11111111-0000-0000-0000-000000000001"),
                Title = "Rapunzel",
                Genre = "Animation",
                YearOfRelease = 2010,
                ProductionHouse = "Disney",
                Director = "Glen Keane",
                Description = "An evil witch named Lucretia despised fairy tale happy endings and plotted to change all that."
            }
        };

        public async Task<Movie> AddMovieList(Movie movie)
        {
            movieList.Add(movie);
            return await Task.FromResult(movie);
        }

        public async Task<Movie> DeleteMovieList(Guid id)
        {
            var oldMovieList = movieList.FirstOrDefault(e => e.Id == id);
            movieList.Remove(oldMovieList);
            return await Task.FromResult(oldMovieList);
        }

        public async Task<Movie> GetMovieList(Guid id)
        {
            var movie = movieList.FirstOrDefault(e => e.Id == id);
            return await Task.FromResult(movie);
        }

        public async Task<Movie> UpdateMovieList(Movie movie)
        {
            var oldMovieList = movieList.FirstOrDefault(e => e.Id == movie.Id);
            movieList.Remove(oldMovieList);
            movieList.Add(movie);
            return await Task.FromResult(movie);
        }
    }
}
