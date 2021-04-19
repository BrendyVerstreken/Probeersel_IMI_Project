using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string YearOfRelease { get; set; }
        public string ProductionHouse { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public Guid OwnerId { get; set; }
    }
}
