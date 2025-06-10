
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

        public const int COLUMNS = 3;
        public const int ROWS = 3;

        public static string[,] grid =
          {
                { " ", " ", " " },
                { " ", " ", " " },
                { " ", " ", " " }
            };
        public static void PrintGrid(string[,] grid)
        {
            for (int i = 0; i < ROWS; i++)
            {
                Console.WriteLine(" --- --- ---", Color.Green);

                for (int j = 0; j < COLUMNS; j++)
                {
                    Console.Write("| " + grid[i, j] + " ", Color.Red);
                }

                Console.WriteLine("|", Color.Red);

            }

            Console.WriteLine(" --- --- ---", Color.Green);
        }

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

            for (int row = 0; row < Logic.ROWS; row++)
            {
                for (int col = 0; col < Logic.COLUMNS; col++)
                {
                    if (Logic.grid[row, col] == " ")
                        return true;
                }
            }
            return false;

        }

        //check for a win
        public static bool WinCheck()
        {
            //check for horizontal win
            for (int row = 0; row < ROWS; row++)
            {
                if (grid[row, 0] == grid[row, 1] && grid[row, 1] == grid[row, 2] && grid[row, 0] != " ") 
                {
                    return true;
                }               
            }

            //check for vertical win
            for (int col = 0; col < COLUMNS; col++)
            {
                if (grid[0, col] == grid[1, col] && grid[1, col] == grid[2, col] && grid[0, col] != " ")
                {
                    return true;
                }               
            }

            //check for diagonal win 1
            for (int row = 1; row < ROWS; row++)
            {
                if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2] && grid[0, 0] != " ")
                {
                    return true;
                }
            }

            //check for diagonal win 2
            for (int row = 1; row < ROWS; row++)
            {
                if (grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0] && grid[0, 2] != " ")
                {
                    return true;
                }
            }
            return false;
        }
    }


}

