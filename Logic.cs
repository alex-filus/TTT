
using System;
using System.Collections.Generic;
using System.Data.Common;
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


        public static bool NotFull()
        {
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
        }

    }
}
