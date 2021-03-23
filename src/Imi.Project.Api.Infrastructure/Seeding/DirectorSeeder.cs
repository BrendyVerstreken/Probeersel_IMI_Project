using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Seeding
{
    public class DirectorSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasData(
                new Director { Name = "Chris Buck", Id = Guid.Parse("00000000-0000-0000-0001-000000000000"), },
                new Director { Name = "James Wan", Id = Guid.Parse("00000000-0000-0000-0002-000000000000"), },
                new Director { Name = "Mike Mitchell", Id = Guid.Parse("00000000-0000-0000-0003-000000000000"), },
                new Director { Name = "Marco Brambilla", Id = Guid.Parse("00000000-0000-0000-0004-000000000000"), },
                new Director { Name = "Peter Jackson", Id = Guid.Parse("00000000-0000-0000-0005-000000000000"), },
                new Director { Name = "John Cohen", Id = Guid.Parse("00000000-0000-0000-0006-000000000000"), },
                new Director { Name = "Bryan Singer", Id = Guid.Parse("00000000-0000-0000-0007-000000000000"), }
                    );
        }
    }
}
