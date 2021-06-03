using Imi.Project.Blazor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Models
{
    public class PlayDisc
    {
        public DiscColor Color;

        public PlayDisc()
        {
            Color = DiscColor.Blank;
        }

        public PlayDisc(DiscColor color)
        {
            Color = color;
        }
    }
}
