using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Mobile.Domain.Models
{
    public class MovieItem
    {
        public Guid Id { get; set; }
        public int Order { get; set; }
        public string Genre { get; set; }

    }
}
