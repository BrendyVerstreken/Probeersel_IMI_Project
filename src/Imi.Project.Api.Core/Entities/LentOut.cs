using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class LentOut : EntityBase
    {
        public string Name { get; set; }
        public ICollection<MovieLentout> MovieLentouts { get; set; }
    }
}
