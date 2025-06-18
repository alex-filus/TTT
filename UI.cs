using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TTT;
using Console = Colorful.Console;

namespace TTT
{
    class UI
    {            
        public static void PrintGrid(string[,] grid)
        {
            for (int i = 0; i < Constants.ROWS; i++)
            {
                Console.WriteLine(" --- --- ---", Color.Green);
                for (int j = 0; j < Constants.COLUMNS; j++)
                {
                    Console.Write("| " + grid[i, j] + " ", Color.Red);
                }
                Console.WriteLine("|", Color.Red);
            }
            Console.WriteLine(" --- --- ---", Color.Green);
        }

        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe! Let's play!");
            Console.WriteLine();
        }

        public static string AskUserForSymbol()
        {
            Console.WriteLine($"What symbol would you like to be? \nPress {Constants.SYMBOL_CHOICE_O} or {Constants.SYMBOL_CHOICE_X}.");
            string symbolChoice = Console.ReadLine()?.ToUpper();

            // User chooses a symbol
            while (symbolChoice != Constants.SYMBOL_CHOICE_O && symbolChoice != Constants.SYMBOL_CHOICE_X)
            {
                Console.WriteLine("Incorrect input. Please try again.");
                symbolChoice = Console.ReadLine()?.ToUpper();
            }

            Console.WriteLine($"You chose: {symbolChoice}");
            return symbolChoice;
        }        
              

        // Ask user to choose a spot
        public static void UserTurn(string symbolChoice, string [,] grid)
        {
            while (true)
            {

                Console.WriteLine();
                Console.WriteLine($"Where would you like to place the {symbolChoice}?");
                Console.WriteLine("Which column? Type 0, 1 or 2.");
                string columnChoice = Console.ReadLine();
                Console.WriteLine("Which row? Type 0, 1 or 2.");
                string rowChoice = Console.ReadLine();
                int row;
                int column;

                if (int.TryParse(columnChoice, out column) && int.TryParse(rowChoice, out row))
                {
                    if (row >= 0 && row < 3 && column >= 0 && column < 3)
                    {
                        if (grid[row, column] == " ")
                        {
                            grid[row, column] = symbolChoice;
                            PrintGrid(grid);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Spot taken! Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid spot. Try again.");
                    }
                }
            }
        }

        //begin computer turn
        public static void PrintComputerTurnMessage()
        {
            Console.WriteLine("Computer's turn....");
            Thread.Sleep(3000);
            Console.WriteLine();
        }
        //Computer placing a symbol
        public static void ComputerTurn(string [,] grid, string computerSymbol)
        {
            Random random = new Random();

            int randomColumn;
            int randomRow;

            // generate a random spot only if not taken
            do
            {
                randomRow = random.Next(0, 3);
                randomColumn = random.Next(0, 3);
            }

            while (grid[randomRow, randomColumn] != " ");

            grid[randomRow, randomColumn] = computerSymbol;
            PrintGrid(grid);
            Console.WriteLine();
        }
    }
}