using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class GenreSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Name = "Animation", Id = Guid.Parse("56f74a86-c9a5-4700-bf41-754db7a7a432"), },
                new Genre { Name = "Thriller", Id = Guid.Parse("f8bc440a-f47b-4376-8c83-2537a9e32afb"), },
                new Genre { Name = "Horror", Id = Guid.Parse("cd9782b8-015e-4099-bdce-ab1e95b1dd37"), },
                new Genre { Name = "Comedy", Id = Guid.Parse("d2c8a028-72e2-43fd-9e6b-845051451901"), },
                new Genre { Name = "Action", Id = Guid.Parse("2a11f3de-7052-43e9-86a0-529f01de586a"), },
                new Genre { Name = "Family", Id = Guid.Parse("eecba59f-dc81-4b60-b677-84aa3088f8fb"), },
                new Genre { Name = "Adventure", Id = Guid.Parse("f8a15d32-4a87-44e8-836c-c5d119d28865"), },
                new Genre { Name = "Sci-Fi", Id = Guid.Parse("1dc8342d-057c-4e8c-b15a-a413ca9eaa6d"), },
                new Genre { Name = "Ramance", Id = Guid.Parse("e11caf64-8647-4472-b5ea-c1498b04e1d9"), },
                new Genre { Name = "Fantasy", Id = Guid.Parse("77f84b77-9d6c-42a3-bd77-46cd04465a47") }
                );
        }
    }
}
