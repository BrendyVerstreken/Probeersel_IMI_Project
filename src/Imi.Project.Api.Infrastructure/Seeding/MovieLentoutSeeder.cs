using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Seeding
{
    public class MovieLentoutSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieLentout>().HasData(
                new MovieLentout { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000001"), LentOutId = Guid.Parse("50000000-0000-0000-0000-0000-00000000"),},
                new MovieLentout { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000002"), LentOutId = Guid.Parse("30000000-0000-0000-0000-0000-00000000"), },
                new MovieLentout { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000008"), LentOutId = Guid.Parse("10000000-0000-0000-0000-0000-00000000"), },
                new MovieLentout { MovieId = Guid.Parse("00000000-0000-0000-0000-0000-00000005"), LentOutId = Guid.Parse("20000000-0000-0000-0000-0000-00000000"), }
                );

        }
    }
}
