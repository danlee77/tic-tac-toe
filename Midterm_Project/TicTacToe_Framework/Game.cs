using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Framework
{
    class Game
    {

        public Lane TopRow { get; set; }

        public Lane MiddleRow { get; set; }

        public Lane BottomRow { get; set; }

        public Lane LeftColumn { get; set; }

        public Lane MiddleColumn { get; set; }

        public Lane RightColumn { get; set; }

        public Lane LeftDiagonal { get; set; }

        public Lane RightDiagonal { get; set; }

        public char WhoseTurnIsIt { get; set; }

        public Game()
        {
            WhoseTurnIsIt = 'X';
            TopRow = new Lane();
            MiddleRow = new Lane();
            BottomRow = new Lane();

            LeftColumn = new Lane();
            MiddleColumn = new Lane();
            RightColumn = new Lane();

            LeftDiagonal = new Lane();
            RightDiagonal = new Lane();
        }

        public string IsGameOver()
        {
            if (TopRow.DidAnyoneWin() == true)
            {
                return $"{TopRow.FirstCell} won!";
            }
            else if (MiddleRow.DidAnyoneWin() == true)
            {
                return $"{MiddleRow.FirstCell} won!";
            }
            else if (BottomRow.DidAnyoneWin() == true)
            {
                return $"{BottomRow.FirstCell} won!";
            }
            else if (LeftColumn.DidAnyoneWin() == true)
            {
                return $"{LeftColumn.FirstCell} won!";
            }
            else if (MiddleColumn.DidAnyoneWin() == true)
            {
                return $"{MiddleColumn.FirstCell} won!";
            }
            else if (RightColumn.DidAnyoneWin() == true)
            {
                return $"{RightColumn.FirstCell} won!";
            }
            else if (LeftDiagonal.DidAnyoneWin() == true)
            {
                return $"{LeftColumn.FirstCell} won!";
            }
            else if (RightDiagonal.DidAnyoneWin() == true)
            {
                return $"{RightColumn.FirstCell} won!";
            }
            else if (TopRow.IsLaneFull() == true && MiddleRow.IsLaneFull() == true && BottomRow.IsLaneFull() == true)
            {
                return $"It's a tie!";
            }
            else
            {
                return "";
            }
        }

        public void FlipTurn()
        {
            if (WhoseTurnIsIt == 'O')
            {
                WhoseTurnIsIt = 'X';
            }
            else if (WhoseTurnIsIt == 'X')
            {
                WhoseTurnIsIt = 'O';
            }
        }
    }
}
