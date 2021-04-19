using Imi.Project.Blazor.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Blazor.Models
{
    public class PlayField
    {
        public PlayDisc[,] Board { get; set; }

        public PlayField()
        {
            //Hier zou ik een lus schrijven met een lus om 42 plaatsen
            //te creeën voor de schijven aan te duiden

            Board = new PlayDisc[7, 6];

            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Board[i, j] = new PlayDisc(DiscColor.Blank);
                }
            }
        }
    }
}
