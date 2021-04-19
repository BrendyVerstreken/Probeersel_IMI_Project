using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class MovieSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = Guid.Parse("28634eed-5342-4a54-bd55-957e8a0193f1"),
                    Title = "Frozen 2",
                    YearRealase = 2019,
                    Image = new Uri("https://www.moviemeter.nl/images/cover/1123000/1123486.jpg?cb=1572281329"),
                    DirectorId = Guid.Parse("3868b15c-93af-44fa-a147-6214358982e6"),
                    ProductionhouseId = Guid.Parse("1194f1d0-cc0a-41b8-9b9b-43e9d83d3bcf")
                },
                new Movie
                {
                    Id = Guid.Parse("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"),
                    Title = "The Conjouring",
                    YearRealase = 2013,
                    Image = new Uri("https://1.bp.blogspot.com/-Gi_sYA5EeOc/XxnkznABTII/AAAAAAAADVo/v1np_MuLBpELyHgf5AwEyHDYhlR1V9v_ACLcBGAsYHQ/s1600/The%2BConjuring%2B2013.jpg"),
                    DirectorId = Guid.Parse("a3da4185-e74f-47e8-9af2-4753cf728ab6"),
                    ProductionhouseId = Guid.Parse("6e835b5a-699e-49cd-b330-d4214ea37e86")
                },
                new Movie
                {
                    Id = Guid.Parse("85518b4d-918e-447b-847b-5769a2f919c9"),
                    Title = "Shrek voor eeuwig en altijd",
                    YearRealase = 2010,
                    Image = new Uri("http://4.bp.blogspot.com/-wuPeTulesvs/VijDC-98v1I/AAAAAAAAALQ/xjD6dzeVFlQ/s1600/shrek_forever_after_2010-movie-poster_1371176093.jpg"),
                    DirectorId = Guid.Parse("d71f81c0-2ffa-49fc-9963-7d0aa57a4c9a"),
                    ProductionhouseId = Guid.Parse("38df2e17-c2ba-49e1-8f83-16d1b070c96c")
                },
                new Movie
                {
                    Id = Guid.Parse("3417e49d-ddc7-48ff-8f96-146cf349d9ed"),
                    Title = "Dinotopia",
                    YearRealase = 2002,
                    Image = new Uri("http://www.moriareviews.com/rongulator/wp-content/uploads/Dinotopia-2002-poster.jpg"),
                    DirectorId = Guid.Parse("f2842d85-39a7-429c-8ae1-81a3174629dd"),
                    ProductionhouseId = Guid.Parse("d09684c4-0097-4d14-85a6-5523f30f4360")
                },
                new Movie
                {
                    Id = Guid.Parse("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"),
                    Title = "Insidious",
                    YearRealase = 2010,
                    Image = new Uri("https://heyitsbenito.files.wordpress.com/2013/10/insidious_2010_3.jpg"),
                    DirectorId = Guid.Parse("a3da4185-e74f-47e8-9af2-4753cf728ab6"),
                    ProductionhouseId = Guid.Parse("a78c00a4-36e9-460a-9e52-eef287bf2977")
                },
                new Movie
                {
                    Id = Guid.Parse("76826400-6497-4cfe-8e46-cb4a1e2cea2a"),
                    Title = "The Hobbit",
                    YearRealase = 2012,
                    Image = new Uri("https://www.newdvdreleasedates.com/images/posters/large/the-hobbit-an-unexpected-journey-2012-5.jpg"),
                    DirectorId = Guid.Parse("cb21d286-2eb3-4caf-a0e2-4385493925d1"),
                    ProductionhouseId = Guid.Parse("272a59bb-9de3-4237-9417-183fc3128c98")
                },
                new Movie
                {
                    Id = Guid.Parse("98218d60-871c-4bba-95f4-5f3eca33bfdc"),
                    Title = "The Angry Birds",
                    YearRealase =2016,
                    Image = new Uri("https://fanart.tv/fanart/movies/153518/movieposter/angry-birds-57529afceafe7.jpg"),
                    DirectorId = Guid.Parse("ef26c1b5-5180-4831-b597-982bbbaba5f0"),
                    ProductionhouseId = Guid.Parse("cd8a9b27-8e95-4407-ad81-e277d15f03ae")
                },
                new Movie
                {
                    Id = Guid.Parse("9421dc55-90ae-4ceb-b7b8-9dd494feb850"),
                    Title = "X-men: Days of future past",
                    YearRealase = 2014,
                    Image = new Uri("https://upload.wikimedia.org/wikipedia/pt/f/f8/X-Men_Dias_Futuro_Esquecido_2014.jpg"),
                    DirectorId = Guid.Parse("d0f18cc5-1344-4502-abb1-80d836e9e7da"),
                    ProductionhouseId = Guid.Parse("64b4720b-d751-4d14-bbd1-a51807be65b8")
                }
                );
        }
    }
}
