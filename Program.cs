using System;
using System.Drawing;
using Console = Colorful.Console;
using System.Threading;
using TTT;

namespace TTT
{
    internal class Program
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

        static void Main(string[] args)
        {
            // Example usage
            PrintGrid(grid);
            UI.StartGame();
        }
    }
}