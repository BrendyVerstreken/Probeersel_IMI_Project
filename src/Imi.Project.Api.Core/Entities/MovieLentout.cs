using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class MovieLentout
    {
        public Guid MovieId { get; set; }
        public Guid LentOutId { get; set; }
        public Movie Movie { get; set; }
        public LentOut LentOut { get; set; }

    }
}
