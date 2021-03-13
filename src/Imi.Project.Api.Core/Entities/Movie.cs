using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class Movie : EntityBase
    {
        public string Title { get; set; }
        public int YearRealase { get; set; }
        public Uri Image { get; set; }
        public ICollection<MovieGenre> MovieGenres { get; set; } //Movie kan meerdere genres hebben
        public Productionhouse Productionhouse { get; set; }
        public ICollection<MovieLentout> MovieLentouts { get; set; }//Movie kan verschillende keren uitgeleend worden
        public Director Director { get; set; }

    }
}
