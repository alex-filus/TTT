
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTT;

namespace TTT
{
    class Logic
    {
        // Assigning a symbol to the computer
        public static void ComputerSymbolAssign()
        {
            if (UI.symbolChoice == UI.SYMBOL_CHOICE_O)
            {
                UI.computerSymbol = UI.SYMBOL_CHOICE_X;
            }
            else
            {
                UI.computerSymbol = UI.SYMBOL_CHOICE_O;
            }
        }

        //check if the grid is filled
        public static bool NotFull()
        {

            for (int row = 0; row < Program.ROWS; row++)
            {
                for (int col = 0; col < Program.COLUMNS; col++)
                {
                    if (Program.grid[row, col] == " ")
                        return true;
                }
            }
            return false;

        }

        //check for a win
        public static bool WinCheck()
        {
            //check for horizontal win
            for (int row = 0; row < Program.ROWS; row++)
            {
                if (Program.grid[row, 0] == Program.grid[row, 1] && Program.grid[row, 1] == Program.grid[row, 2] && Program.grid[row, 0] != " ") 
                {
                    return true;
                }               
            }

            //check for vertical win
            for (int col = 0; col < Program.COLUMNS; col++)
            {
                if (Program.grid[0, col] == Program.grid[1, col] && Program.grid[1, col] == Program.grid[2, col] && Program.grid[0, col] != " ")
                {
                    return true;
                }               
            }

            //check for diagonal win 1
            for (int row = 1; row < Program.ROWS; row++)
            {
                if (Program.grid[0, 0] == Program.grid[1, 1] && Program.grid[1, 1] == Program.grid[2, 2] && Program.grid[0, 0] != " ")
                {
                    return true;
                }
            }

            //check for diagonal win 2
            for (int row = 1; row < Program.ROWS; row++)
            {
                if (Program.grid[0, 2] == Program.grid[1, 1] && Program.grid[1, 1] == Program.grid[2, 0] && Program.grid[0, 2] != " ")
                {
                    return true;
                }
            }
            return false;
        }
    }


}

