using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Seeding
{
    public class GenreSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Name = "Animation", Id = Guid.Parse("00000000-0000-0000-0000-000000000001"), },
                new Genre { Name = "Thriller", Id = Guid.Parse("00000000-0000-0000-0000-000000000002"), },
                new Genre { Name = "Horror", Id = Guid.Parse("00000000-0000-0000-0000-000000000003"), },
                new Genre { Name = "Comedy", Id = Guid.Parse("00000000-0000-0000-0000-000000000004"), },
                new Genre { Name = "Action", Id = Guid.Parse("00000000-0000-0000-0000-000000000005"), },
                new Genre { Name = "Family", Id = Guid.Parse("00000000-0000-0000-0000-000000000006"), },
                new Genre { Name = "Adventure", Id = Guid.Parse("00000000-0000-0000-0000-000000000007"), },
                new Genre { Name = "Sci-Fi", Id = Guid.Parse("00000000-0000-0000-0000-000000000008"), },
                new Genre { Name = "Ramance", Id = Guid.Parse("00000000-0000-0000-0000-000000000009"), },
                new Genre { Name = "Fantasy", Id = Guid.Parse("00000000-0000-0000-0000-000000000010")}
                );
        }
    }
}
