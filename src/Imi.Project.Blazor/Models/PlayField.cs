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

        public DiscColor CurrentTurn { get; set; }
        public WinningPlayer WinningPlayer { get; set; }

        public PlayField()
        {
            Reset();
            //Hier zou ik een lus schrijven met een lus om 42 plaatsen
            //te creeën voor de schijven aan te duiden

            //Board = new PlayDisc[7, 6];

            //for (int i = 0; i <= 6; i++)
            //{
            //    for (int j = 0; j <= 5; j++)
            //    {
            //        Board[i, j] = new PlayDisc(DiscColor.Blank);
            //    }
            //}
        }

        public void Reset()
        {
            Board = new PlayDisc[7, 6];

            //Populate the Board with blank pieces
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    Board[i, j] = new PlayDisc(DiscColor.Blank);
                }
            }

            CurrentTurn = DiscColor.Red;
            WinningPlayer = null;
        }

        public void PieceClicked(int x, int y)
        {
            //If a winning play has already been made, don't do anything.
            if (WinningPlayer != null) { return; }

            PlayDisc clickedSpace = Board[x, y];

            //The piece must "fall" to the lowest unoccupied space in the clicked column
            if (clickedSpace.Color == DiscColor.Blank)
            {
                while (y < 5)
                {
                    PlayDisc nextSpace = Board[x, y + 1];

                    y += 1;
                    if (nextSpace.Color == DiscColor.Blank)
                    {
                        clickedSpace = nextSpace;
                    }
                }
                clickedSpace.Color = CurrentTurn;

            }

            //After every move, check to see if that move was a winning move.
            WinningPlayer = GetWinner();
            if (WinningPlayer == null)
            {
                SwitchTurns();
            }
        }

        public void SwitchTurns()
        {
            CurrentTurn = CurrentTurn == DiscColor.Red ? DiscColor.Yellow : DiscColor.Red;
        }

        public bool IsPlayDiscAWinningPiece(int i, int j)
        {
            return WinningPlayer?.WinningMoves?.Contains($"{i},{j}") ?? false;
        }

        private WinningPlayer GetWinner()
        {
            WinningPlayer winningPlay = null;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    winningPlay = EvaluatePieceForWinner(i, j, Direction.Up);
                    if (winningPlay != null) { return winningPlay; }

                    winningPlay = EvaluatePieceForWinner(i, j, Direction.UpRight);
                    if (winningPlay != null) { return winningPlay; }

                    winningPlay = EvaluatePieceForWinner(i, j, Direction.Right);
                    if (winningPlay != null) { return winningPlay; }

                    winningPlay = EvaluatePieceForWinner(i, j, Direction.DownRight);
                    if (winningPlay != null) { return winningPlay; }
                }
            }

            return winningPlay;

        }
        private WinningPlayer EvaluatePieceForWinner(int i, int j, Direction dir)
        {
            PlayDisc currentPiece = Board[i, j];
            if (currentPiece.Color == DiscColor.Blank)
            {
                return null;
            }

            int inARow = 1;
            int iNext = i;
            int jNext = j;

            var winningMoves = new List<string>();

            while (inARow < 4)
            {
                switch (dir)
                {
                    case Direction.Up:
                        jNext = jNext - 1;
                        break;
                    case Direction.UpRight:
                        iNext = iNext + 1;
                        jNext = jNext - 1;
                        break;
                    case Direction.Right:
                        iNext = iNext + 1;
                        break;
                    case Direction.DownRight:
                        iNext = iNext + 1;
                        jNext = jNext + 1;
                        break;
                }
                if (iNext < 0 || iNext >= 7 || jNext < 0 || jNext >= 6) { break; }
                if (Board[iNext, jNext].Color == currentPiece.Color)
                {
                    winningMoves.Add($"{iNext},{jNext}");
                    inARow++;
                }
                else
                {
                    return null;
                }
            }

            if (inARow >= 4)
            {
                winningMoves.Add($"{i},{j}");

                return new WinningPlayer()
                {
                    WinningMoves = winningMoves,
                    WinningColor = currentPiece.Color,
                    WinningDirection = dir,
                };
            }

            return null;
        }
    }
}
