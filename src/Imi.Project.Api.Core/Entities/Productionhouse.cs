using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class Productionhouse : EntityBase
    {
        public string Name { get; set; }
        public string Headquarters { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
