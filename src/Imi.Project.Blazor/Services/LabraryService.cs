using Imi.Project.Blazor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Services
{
    public class LabraryService : ICRUDService<LabraryListItem, LabraryItem>
    {
        static List<LabraryItem> items = new List<LabraryItem>
        {
            new LabraryItem()
            {
                Id = 1,
                Title = "Rapunzel",
                YearRelease = 2010,
                ProductionHouse = "Disney",
                Director = "Glen Keane",
                Description = "An evil witch named Lucretia despised fairy tale happy endings and plotted to change all that."
            },
            new LabraryItem()
            {
                Id = 2,
                Title = "The Conjuring",
                YearRelease = 2013,
                ProductionHouse = "Warner Bros",
                Director = "Rob Cowan",
                Description = "It's a movie that is inspreratet on a house that exist"
            },
            new LabraryItem()
            {
                Id = 3,
                Title = "Fronzen 2",
                YearRelease = 2019,
                ProductionHouse = "Disney",
                Director = "Peter Del Vecho",
                Description = "The story of this movie get about a girl with icy powers that feel she's looking for something"
            }
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
            return Task.FromResult(items.SingleOrDefault(x => x.Id == id));
        }

        public Task<LabraryListItem[]> GetList()
        {
            return Task.FromResult(
                items.Select(x => new LabraryListItem()
                {
                    Id = x.Id,
                    Title = x.Title
                }).ToArray()
            );
        }

        public Task<LabraryItem> GetNew()
        {
            return Task.FromResult(new LabraryItem());
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
