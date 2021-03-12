using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Models
{
    public class LabraryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        //public int GenreId { get; set; }
        public int YearRelease { get; set; }
        public string Director { get; set; }
        public string ProductionHouse { get; set; }
        public string Description { get; set; }
        //public InputSelectItem[] Genres { get; set; }
    }
}
