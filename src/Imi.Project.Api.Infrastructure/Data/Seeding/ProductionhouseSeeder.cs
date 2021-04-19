using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class ProductionhouseSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Productionhouse>().HasData(
                new Productionhouse
                {
                    Id = Guid.Parse("1194f1d0-cc0a-41b8-9b9b-43e9d83d3bcf"),
                    Name = "Disney",
                    Headquarters = "Burbank, Californië",
                },
                new Productionhouse
                {
                    Id = Guid.Parse("6e835b5a-699e-49cd-b330-d4214ea37e86"),
                    Name = "New Line Cinema",
                    Headquarters = "Hollywood",
                },
                new Productionhouse
                {
                    Id = Guid.Parse("38df2e17-c2ba-49e1-8f83-16d1b070c96c"),
                    Name = "DreamWorks Animation",
                    Headquarters = "Rendwoon City, Califorië",
                },
                new Productionhouse
                {
                    Id = Guid.Parse("d09684c4-0097-4d14-85a6-5523f30f4360"),
                    Name = "RTL Television Germany",
                    Headquarters = "Cologne, Germany",
                },
                new Productionhouse
                {
                    Id = Guid.Parse("a78c00a4-36e9-460a-9e52-eef287bf2977"),
                    Name = "BlumHouse Productions",
                    Headquarters = "Los Angeles, Califorië",
                },
                new Productionhouse
                {
                    Id = Guid.Parse("cd8a9b27-8e95-4407-ad81-e277d15f03ae"),
                    Name = "Columbia Pictures",
                    Headquarters = "Culver City, Californië",
                },
                new Productionhouse
                {
                    Id = Guid.Parse("64b4720b-d751-4d14-bbd1-a51807be65b8"),
                    Name = "20th Century Studios",
                    Headquarters = "Century City, Los Angeles",
                },
                new Productionhouse
                {
                    Id = Guid.Parse("272a59bb-9de3-4237-9417-183fc3128c98"),
                    Name = "Warner Bros",
                    Headquarters = "Burbank, Californië",
                }
                );
        }
    }
}
