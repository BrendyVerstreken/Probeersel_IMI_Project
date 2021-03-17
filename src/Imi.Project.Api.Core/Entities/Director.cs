using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class Director : EntityBase
    {
        public string Name { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}
