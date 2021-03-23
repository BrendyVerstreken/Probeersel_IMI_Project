using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Seeding
{
    public class MovieSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieSeeder>().HasData(
                new Movie { Title = "Frozen 2", YearRealase = 2019, Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), Image = new Uri("https://www.moviemeter.nl/images/cover/1123000/1123486.jpg?cb=1572281329"), DirectorId = Guid.Parse("00000000-0000-0000-0001-0000-00000000"), ProductionhouseId = Guid.Parse("00000000-0000-0000-0000-000100000000"), },
                new Movie { Title = "The Conjouring", YearRealase = 2013, Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), Image = new Uri("https://1.bp.blogspot.com/-Gi_sYA5EeOc/XxnkznABTII/AAAAAAAADVo/v1np_MuLBpELyHgf5AwEyHDYhlR1V9v_ACLcBGAsYHQ/s1600/The%2BConjuring%2B2013.jpg"), DirectorId = Guid.Parse("00000000-0000-0000-0002-000000000000"), },
                new Movie { Title = "Shrek voor eeuwig en altijd", YearRealase = 2010, Id = Guid.Parse("00000000-0000-0000-00000000-00000003"), Image = new Uri("http://4.bp.blogspot.com/-wuPeTulesvs/VijDC-98v1I/AAAAAAAAALQ/xjD6dzeVFlQ/s1600/shrek_forever_after_2010-movie-poster_1371176093.jpg"), DirectorId = Guid.Parse("00000000-0000-0000-0003-000000000000"), ProductionhouseId = Guid.Parse("00000000-0000-0000-0000-0003-00000000"), },
                new Movie { Title = "Dinotopia", YearRealase = 2002, Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), Image = new Uri("http://www.moriareviews.com/rongulator/wp-content/uploads/Dinotopia-2002-poster.jpg"),DirectorId = Guid.Parse("00000000-0000-0000-00004-0000-00000000"), ProductionhouseId = Guid.Parse("00000000-0000-0000-0000-000400000000") ,},
                new Movie { Title = "Insidious", YearRealase = 2010, Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), Image = new Uri("https://heyitsbenito.files.wordpress.com/2013/10/insidious_2010_3.jpg"), DirectorId = Guid.Parse("00000000-0000-0000-0002-0000-00000000"), ProductionhouseId = Guid.Parse("00000000-0000-0000-0000-000500000000"),},
                new Movie { Title = "The Hobbit", YearRealase = 2012, Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), Image = new Uri("https://www.newdvdreleasedates.com/images/posters/large/the-hobbit-an-unexpected-journey-2012-5.jpg"), DirectorId = Guid.Parse("00000000-0000-0000-0005-0000-00000000"), ProductionhouseId = Guid.Parse("00000000-0000-0000-0000-000800000000"), },
                new Movie { Title = "The Angry Birds", YearRealase = 2016, Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), Image = new Uri("https://fanart.tv/fanart/movies/153518/movieposter/angry-birds-57529afceafe7.jpg"), DirectorId = Guid.Parse("00000000-0000-0000-0006-0000-00000000") , ProductionhouseId = Guid.Parse("00000000-0000-0000-0000-000600000000") ,},
                new Movie { Title = "X-men: Days of future past", YearRealase = 2014, Id = Guid.Parse("00000000-0000-0000-00000000-00000008"), Image = new Uri("https://upload.wikimedia.org/wikipedia/pt/f/f8/X-Men_Dias_Futuro_Esquecido_2014.jpg"), DirectorId = Guid.Parse("00000000-0000-0000-0007-0000-00000000"), ProductionhouseId = Guid.Parse("00000000-0000-0000-0000-000700000000") }
                );
        }
    }
}
