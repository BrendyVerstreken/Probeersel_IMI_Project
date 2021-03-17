using Imi.Project.Api.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Seeding
{
    public class LentoudSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LentOut>().HasData(
                new LentOut { Name = "Brendy", Id = Guid.Parse("10000000-0000-0000-0000-0000-00000000"),},
                new LentOut { Name = "Steve", Id = Guid.Parse("20000000-0000-0000-0000-0000-00000000"), },
                new LentOut { Name = "Imana", Id = Guid.Parse("30000000-0000-0000-0000-0000-00000000"), },
                new LentOut { Name = "Amalia", Id = Guid.Parse("40000000-0000-0000-0000-0000-00000000"), },
                new LentOut { Name = "Sharona", Id = Guid.Parse("50000000-0000-0000-0000-0000-00000000"), }
                );
        }
    }
}
