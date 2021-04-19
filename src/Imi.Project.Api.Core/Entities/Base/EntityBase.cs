using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imi.Project.Api.Core.Entities.Base
{
    public abstract class EntityBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}
