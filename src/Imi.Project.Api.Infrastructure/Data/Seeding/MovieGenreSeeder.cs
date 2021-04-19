using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class MovieGenreSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieGenre>().HasData(
                new MovieGenre { MovieId = Guid.Parse("28634eed-5342-4a54-bd55-957e8a0193f1"), GenreId = Guid.Parse("56f74a86-c9a5-4700-bf41-754db7a7a432"), },
                new MovieGenre { MovieId = Guid.Parse("28634eed-5342-4a54-bd55-957e8a0193f1"), GenreId = Guid.Parse("f8a15d32-4a87-44e8-836c-c5d119d28865"), },
                new MovieGenre { MovieId = Guid.Parse("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"), GenreId = Guid.Parse("cd9782b8-015e-4099-bdce-ab1e95b1dd37"), }, 
                new MovieGenre { MovieId = Guid.Parse("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"), GenreId = Guid.Parse("f8bc440a-f47b-4376-8c83-2537a9e32afb"), },
                new MovieGenre { MovieId = Guid.Parse("85518b4d-918e-447b-847b-5769a2f919c9"), GenreId = Guid.Parse("56f74a86-c9a5-4700-bf41-754db7a7a432"), },
                new MovieGenre { MovieId = Guid.Parse("85518b4d-918e-447b-847b-5769a2f919c9"), GenreId = Guid.Parse("f8a15d32-4a87-44e8-836c-c5d119d28865"), },
                new MovieGenre { MovieId = Guid.Parse("85518b4d-918e-447b-847b-5769a2f919c9"), GenreId = Guid.Parse("77f84b77-9d6c-42a3-bd77-46cd04465a47"), },
                new MovieGenre { MovieId = Guid.Parse("85518b4d-918e-447b-847b-5769a2f919c9"), GenreId = Guid.Parse("d2c8a028-72e2-43fd-9e6b-845051451901"), },
                new MovieGenre { MovieId = Guid.Parse("3417e49d-ddc7-48ff-8f96-146cf349d9ed"), GenreId = Guid.Parse("77f84b77-9d6c-42a3-bd77-46cd04465a47"), },
                new MovieGenre { MovieId = Guid.Parse("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"), GenreId = Guid.Parse("cd9782b8-015e-4099-bdce-ab1e95b1dd37"), },
                new MovieGenre { MovieId = Guid.Parse("76826400-6497-4cfe-8e46-cb4a1e2cea2a"), GenreId = Guid.Parse("f8a15d32-4a87-44e8-836c-c5d119d28865"), },
                new MovieGenre { MovieId = Guid.Parse("76826400-6497-4cfe-8e46-cb4a1e2cea2a"), GenreId = Guid.Parse("77f84b77-9d6c-42a3-bd77-46cd04465a47"), },
                new MovieGenre { MovieId = Guid.Parse("98218d60-871c-4bba-95f4-5f3eca33bfdc"), GenreId = Guid.Parse("56f74a86-c9a5-4700-bf41-754db7a7a432"), },
                new MovieGenre { MovieId = Guid.Parse("98218d60-871c-4bba-95f4-5f3eca33bfdc"), GenreId = Guid.Parse("d2c8a028-72e2-43fd-9e6b-845051451901"), },
                new MovieGenre { MovieId = Guid.Parse("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), GenreId = Guid.Parse("2a11f3de-7052-43e9-86a0-529f01de586a"), },
                new MovieGenre { MovieId = Guid.Parse("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), GenreId = Guid.Parse("f8a15d32-4a87-44e8-836c-c5d119d28865"), },
                new MovieGenre { MovieId = Guid.Parse("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), GenreId = Guid.Parse("77f84b77-9d6c-42a3-bd77-46cd04465a47"), },
                new MovieGenre { MovieId = Guid.Parse("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), GenreId = Guid.Parse("1dc8342d-057c-4e8c-b15a-a413ca9eaa6d"), }
                );

        }
    }
}
