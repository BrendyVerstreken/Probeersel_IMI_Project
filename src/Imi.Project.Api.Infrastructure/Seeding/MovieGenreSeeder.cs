using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Seeding
{
    public class MovieGenreSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieGenre>().HasData(
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000001"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000001"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000001"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000007"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000002"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000003"), }, 
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000002"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000002"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000001"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000007"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000010"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000004"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000004"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000010"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000005"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000003"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000006"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000007"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000006"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000010"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000007"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000001"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000007"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000004"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000008"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000005"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000008"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000007"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000008"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000010"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000008"), GenreId = Guid.Parse("00000000-0000-0000-0000-0000-00000008"), }
                );

        }
    }
}
