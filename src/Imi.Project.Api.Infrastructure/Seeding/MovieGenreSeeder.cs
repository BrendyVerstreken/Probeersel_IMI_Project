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
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000001"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000001"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000002"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000003"), }, 
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000002"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000002"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000010"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000003"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000004"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000010"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000005"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000003"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000006"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000006"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000010"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000007"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000001"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000007"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000004"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000008"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000005"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000008"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000007"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000008"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000010"), },
                new MovieGenre { MovieId = Guid.Parse("00000000-0000-0000-0000-000000000008"), GenreId = Guid.Parse("00000000-0000-0000-0000-000000000008"), }
                );

        }
    }
}
