using System.Collections.Generic;
using Imi.Project.Blazor.Enums;

namespace Imi.Project.Blazor.Models
{
    public class WinningPlayer
    {
        public List<string> WinningMoves { get; set; }
        public Direction WinningDirection { get; set; }
        public DiscColor WinningColor { get; set; }
    }
}
