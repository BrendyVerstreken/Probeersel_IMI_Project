using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class MovieLentoutSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieLentout>().HasData(
                new MovieLentout { MovieId = Guid.Parse("28634eed-5342-4a54-bd55-957e8a0193f1"), LentOutId = Guid.Parse("0855fe6f-1966-4c14-8a50-33d2f5924cd6"), },
                new MovieLentout { MovieId = Guid.Parse("f34d6513-8899-4d9f-98d7-6d521f7c1f3e"), LentOutId = Guid.Parse("d610ddc2-66e1-4c5e-840b-6174964d3a90"), },
                new MovieLentout { MovieId = Guid.Parse("9421dc55-90ae-4ceb-b7b8-9dd494feb850"), LentOutId = Guid.Parse("0db643f3-115e-4c5e-b8f1-22e9e0b9659f"), },
                new MovieLentout { MovieId = Guid.Parse("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"), LentOutId = Guid.Parse("f8ab5013-ef70-4cd6-8327-2c526beceb3b"), },
                new MovieLentout { MovieId = Guid.Parse("5a198a0c-e639-4bc0-8160-c114ccb9ecc4"), LentOutId = Guid.Parse("0855fe6f-1966-4c14-8a50-33d2f5924cd6"), },
                new MovieLentout { MovieId = Guid.Parse("76826400-6497-4cfe-8e46-cb4a1e2cea2a"), LentOutId = Guid.Parse("bcab7b0b-529a-4243-aac0-6a9daf3a63da") }
                );

        }
    }
}
