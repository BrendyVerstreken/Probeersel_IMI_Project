using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class DirectorSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasData(
                new Director { Name = "Chris Buck", Id = Guid.Parse("3868b15c-93af-44fa-a147-6214358982e6"), },
                new Director { Name = "James Wan", Id = Guid.Parse("a3da4185-e74f-47e8-9af2-4753cf728ab6"), },
                new Director { Name = "Mike Mitchell", Id = Guid.Parse("d71f81c0-2ffa-49fc-9963-7d0aa57a4c9a"), },
                new Director { Name = "Marco Brambilla", Id = Guid.Parse("f2842d85-39a7-429c-8ae1-81a3174629dd"), },
                new Director { Name = "Peter Jackson", Id = Guid.Parse("cb21d286-2eb3-4caf-a0e2-4385493925d1"), },
                new Director { Name = "John Cohen", Id = Guid.Parse("ef26c1b5-5180-4831-b597-982bbbaba5f0"), },
                new Director { Name = "Bryan Singer", Id = Guid.Parse("d0f18cc5-1344-4502-abb1-80d836e9e7da"), }
                    );
        }
    }
}