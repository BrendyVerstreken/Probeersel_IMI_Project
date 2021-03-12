using Imi.Project.Mobile.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Mobile.Domain.Services
{
    public interface IMovieService
    {
        Task<Movie> GetMovieList(Guid movieId);
        Task<Movie> UpdateMovieList(Movie movie);
        Task<Movie> AddMovieList(Movie movie);
        Task<Movie> DeleteMovieList(Guid id);

        Task<IQueryable<Movie>> GetMovieListsForUser(Guid userid);
    }
}
