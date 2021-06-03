using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class Movie : EntityBase
    {
        public string Title { get; set; }
        public Uri Image { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; } //Movie kan meerdere genres hebben
        public Guid ProductionhouseId { get; set; }
        public ICollection<MovieLentout> MovieLentouts { get; set; }//Movie kan verschillende keren uitgeleend worden
        public Guid DirectorId { get; set; }

    }
}
