using Imi.Project.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public class LabraryService : ICRUDService<LabraryListItem, LabraryItem>
    {
        static InputSelectItem[] genres = new InputSelectItem[]
        {
            new InputSelectItem() { Value = "1", Label = "Animation" },
            new InputSelectItem() { Value = "2", Label = "Thriller" },
            new InputSelectItem() { Value = "3", Label = "Action" },
            new InputSelectItem() { Value = "4", Label = "Horror" },
            new InputSelectItem() { Value = "5", Label = "Comedy" },
            new InputSelectItem() { Value = "6", Label = "Fantasy" },
            new InputSelectItem() { Value = "7", Label = "Sci-Fi" },
            new InputSelectItem() { Value = "8", Label = "Adventure" },
            new InputSelectItem() { Value = "9", Label = "Family" },
            new InputSelectItem() { Value = "10", Label = "Drama" },
            new InputSelectItem() { Value = "11", Label = "Romance" }
        };
        
        static List<LabraryItem> items = new List<LabraryItem>
        {
            new LabraryItem()
            {
                Id = 1,
                Title = "Rapunzel",
                GenreId = "1",
                YearRelease = 2010,
                ProductionHouse = "Disney",
                Director = "Glen Keane",
                Description = "An evil witch named Lucretia despised fairy tale happy endings and plotted to change all that.",
                Cover = new Uri("https://s1.thcdn.com/productimg/1600/1600/11408850-1354458444808092.jpg")
            },
            new LabraryItem()
            {
                Id = 2,
                Title = "The Conjuring",
                GenreId = "4",
                YearRelease = 2013,
                ProductionHouse = "Warner Bros",
                Director = "Rob Cowan",
                Description = "It's a movie that is inspreratet on a house that exist",
                Cover = new Uri("https://1.bp.blogspot.com/-AWHincTlbg0/Xl_ba4h47gI/AAAAAAAAK-M/vJnhn-zryokZQEeC6pNS25-tPXTQEgTwQCLcBGAsYHQ/s1600/MM00202393-1.jpg")
            },
            new LabraryItem()
            {
                Id = 3,
                Title = "Frozen 2",
                GenreId = "1",
                YearRelease = 2019,
                ProductionHouse = "Disney",
                Director = "Peter Del Vecho",
                Description = "The story of this movie get about a girl with icy powers that feel she's looking for something",
                Cover = new Uri("http://www.kiwithebeauty.com/wp-content/uploads/2020/02/frozen-2-poster.jpg")
            },
            new LabraryItem()
            {
                Id = 4,
                Title = "Chocolat",
                GenreId = "11",
                YearRelease = 2000,
                ProductionHouse = "Miramax",
                Director = "Lasse Hallström",
                Description = "It's a romance movie about a woman that have a chocolat-store in a village in France and she meet a man",
                Cover = new Uri("https://assets.catawiki.nl/assets/2016/6/10/8/f/3/8f3e4862-2ef3-11e6-90b1-d69fceb2fce5.jpg")
            },
            new LabraryItem()
            {
                Id = 5,
                Title = "Star wars I",
                GenreId = "7",
                YearRelease = 1999,
                ProductionHouse = "20th Century Fox",
                Director = "George Lucas",
                Description = "This movie is a story about the Force and the Evil.",
                Cover = new Uri("http://img.over-blog-kiwi.com/1/20/35/30/20140822/ob_c6ae33_affiche-star-wars-episode-i-la-menace.jpg")
            },
        };

        public Task Create(LabraryItem item)
        {
            item.Id = items.Count() > 0 ? items.Max(x => x.Id) + 1 : 1;
            items.Add(item);
            return Task.CompletedTask;

        }

        public Task Delete(int id)
        {
            var movie = items.SingleOrDefault(x => x.Id == id);
            if (items == null) throw new ArgumentException("Movie not found");
            items.Remove(movie);
            return Task.CompletedTask;
        }

        public Task<LabraryItem> Get(int id)
        {
            var movie = items.SingleOrDefault(x => x.Id == id);
            movie.Genres = genres;
            return Task.FromResult(movie);
        }

        public Task<LabraryListItem[]> GetList()
        {
            return Task.FromResult(
                items.Select(x => new LabraryListItem()
                {
                    Id = x.Id,
                    Title = x.Title,
                    Description = x.Description,
                    Genre = genres
                        .Where(y => y.Value == x.GenreId)
                        .Select(y => y.Label)
                        .SingleOrDefault()
                }).ToArray()
            );
        }

        public Task<LabraryItem> GetNew()
        {
            var movie = new LabraryItem();
            movie.Genres = genres;
            movie.GenreId = genres.First().Value;
            return Task.FromResult(movie);

        }

        public Task Update(LabraryItem item)
        {
            var movie = items.SingleOrDefault(x => x.Id == item.Id);
            if (movie == null) throw new ArgumentException("Movie not found");
            movie.Title = item.Title;
            movie.YearRelease = item.YearRelease;
            movie.Description = item.Description;
            movie.ProductionHouse = item.ProductionHouse;
            movie.Director = item.Director;
            return Task.CompletedTask;
        }

        
    }
}
