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
                YearOfRelease = "2010",
                ProductionHouse = "Disney",
                Director = "Glen Keane",
                Description = "An evil witch named Lucretia despised fairy tale happy endings and plotted to change all that."
            },            
            new Movie
            {
                Id = Guid.Parse("11111111-0000-0000-0000-000000000002"),
                Title = "The Conjuring",
                Genre = "Thriller",
                YearOfRelease = "2013",
                ProductionHouse = "New Cinema Line",
                Director = "Chan wan",
                Description = "A very nice movie to get chills"
            },
            new Movie
            {
                Id = Guid.Parse("11111111-0000-0000-0000-000000000003"),
                Title = "Chocolat",
                Genre = "Romanance",
                YearOfRelease = "2001",
                ProductionHouse = "Miramax Films",
                Director = "Harvey Weinstein",
                Description = "n het Franse dorpje Lansquenet is al jarenlang niets bijzonders gebeurd. Het dorpje staat onder het strenge bestuur van de burgemeester, de Comte de Reynaud"
            },
            new Movie
            {
                Id = Guid.Parse("11111111-0000-0000-0000-000000000004"),
                Title = "Star Wars: Episode I: The Phantom Menace",
                Genre = "Sci-Fy",
                YearOfRelease = "1999",
                ProductionHouse = "20th Century Fox",
                Director = "George Lucas",
                Description = "De Handelsfederatie heeft de vreedzame planeet Naboo geblokkeerd in de hoop een handelsconflict in haar voordeel te kunnen beslechten. De Galactische Senaat stuurt twee Jedi-ridders, Jedi-meester Qui-Gon Jinn en zijn padawan Obi-Wan Kenobi naar het ruimteschip Lucrehulk, om te onderhandelen. De droids van de Handelsfederatie proberen hen echter te doden en zetten een invasie van Naboo in gang, onder druk van het brein achter de blokkade: de mysterieuze Sith Lord Darth Sidious. Er worden allemaal MTT's naar de planeet Naboo gestuurd."
            },
            new Movie
            {
                Id = Guid.Parse("11111111-0000-0000-0000-000000000005"),
                Title = "Star Wars: Episode II: Attack of the Clones",
                Genre = "Sci-Fy",
                YearOfRelease = "2002",
                ProductionHouse = "20th Century Fox",
                Director = "George Lucas",
                Description = "Tien jaar zijn verstreken sinds de vorige film. Er heerst onrust in de Galactische Republiek. Steeds meer planeten hebben zich afgescheiden van de Republiek en vormen nu als de Separatisten een grote dreiging onder leiding van een voormalige Jedi, graaf Dooku. De Republiek moet het hoofd bieden aan deze nieuwe dreiging en daarom wordt er in de senaat druk gediscussieerd of er een groot algemeen leger voor de Republiek komen moet. Op Coruscant wordt een aanslag gepleegd op Padmé Amidala om haar te vermoorden, maar dat mislukt."
            },

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

        public async Task<IQueryable<Movie>> GetMovieListsForUser(Guid userid)
        {
            var movies = movieList.Where(e => e.OwnerId == userid).AsQueryable();
            return await Task.FromResult(movies);
        }
    }
}
