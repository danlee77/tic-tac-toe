using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Framework
{
    class Lane
    {

        public char FirstCell { get; set; }

        public char SecondCell { get; set; }

        public char ThirdCell { get; set; }

        public Lane()
        {
            FirstCell = ' ';
            SecondCell = ' ';
            ThirdCell = ' ';
        }

        public bool DidAnyoneWin()
        {
            if (FirstCell == 'X' && SecondCell == 'X' && ThirdCell == 'X')
            {
                return true;
            }
            else if (FirstCell == 'O' && SecondCell == 'O' && ThirdCell == 'O')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLaneFull()
        {
            if ((FirstCell == 'X' || FirstCell == 'O') && (SecondCell == 'X' || SecondCell == 'O') && (ThirdCell == 'X' || ThirdCell == 'O'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
