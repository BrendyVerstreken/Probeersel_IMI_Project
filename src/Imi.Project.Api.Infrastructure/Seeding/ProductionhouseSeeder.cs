using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Seeding
{
    public class ProductionhouseSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productionhouse>().HasData(
                new Productionhouse { Name = "Disney", Headquarters = "Burbank, Californië", Id = Guid.Parse("00000000-0000-0000-0000-000100000000"), },
                new Productionhouse { Name = "New Line Cinema", Headquarters = "Hollywood", Id = Guid.Parse("00000000-0000-0000-0000-0002-00000000"), },
                new Productionhouse { Name = "DreamWorks Animation", Headquarters = "Rendwoon City, Califorië", Id = Guid.Parse("00000000-0000-0000-0000-000300000000"), },
                new Productionhouse { Name = "RTL Television Germany", Headquarters = "Cologne, Germany", Id = Guid.Parse("00000000-0000-0000-0000-000400000000"), },
                new Productionhouse { Name = "BlumHouse Productions", Headquarters = "Los Angeles, Califorië", Id = Guid.Parse("00000000-0000-0000-0000-000500000000"), },
                new Productionhouse { Name = "Columbia Pictures", Headquarters = "Culver City, Californië", Id = Guid.Parse("00000000-0000-0000-0000-000600000000"), },
                new Productionhouse { Name = "20th Century Studios", Headquarters = "Century City, Los Angeles", Id = Guid.Parse("00000000-0000-0000-0000-000700000000"), },
                new Productionhouse { Name = "Warner Bros", Headquarters = "Burbank, Californië", Id = Guid.Parse("00000000-0000-0000-0000-000800000000") }
                );
        }
    }
}
