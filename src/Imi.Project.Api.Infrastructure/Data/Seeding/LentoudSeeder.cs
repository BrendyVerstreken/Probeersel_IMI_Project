using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Data.Seeding
{
    public class LentoudSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LentOut>().HasData(
                new LentOut { Name = "Brendy", Id = Guid.Parse("0db643f3-115e-4c5e-b8f1-22e9e0b9659f"),},
                new LentOut { Name = "Steve", Id = Guid.Parse("f8ab5013-ef70-4cd6-8327-2c526beceb3b"), },
                new LentOut { Name = "Imana", Id = Guid.Parse("d610ddc2-66e1-4c5e-840b-6174964d3a90"), },
                new LentOut { Name = "Amalia", Id = Guid.Parse("5779b386-192f-45f0-a77c-e0c3ada65801"), },
                new LentOut { Name = "Sharona", Id = Guid.Parse("0855fe6f-1966-4c14-8a50-33d2f5924cd6"), },
                new LentOut { Name = "Hilde", Id = Guid.Parse("bcab7b0b-529a-4243-aac0-6a9daf3a63da"), }
                );
        }
    }
}
