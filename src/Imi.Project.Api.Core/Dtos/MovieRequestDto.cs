using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class MovieRequestDto : DtoBase
    {
        [Required]
        public string Tilte { get; set; }
        public int YearRelease { get; set; }
        public Uri Image { get; set; }
        public Guid DirectorId { get; set; }
        public Guid ProductionHouseId { get; set; }
    }
}
