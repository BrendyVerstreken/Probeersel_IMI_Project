using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class MovieResponseDto : DtoBase
    {
        public string Title { get; set; }
        public int YearRelease { get; set; }
        public Uri Image { get; set; }
        public Guid DirectorId { get; set; }
        public Guid ProductionHouseId { get; set; }
        public ICollection<GenreResponseDto> Genres { get; set; }
        public ICollection<LentOutResponseDto> LentOuts { get; set; }
    }

    
}
