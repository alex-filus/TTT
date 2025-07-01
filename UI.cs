using System.Drawing;
using Console = Colorful.Console;

namespace TTT
{
    class UI
    {
        public static void PrintGrid(string[,] grid)
        {
            //top border
            for (int j = 0; j < Constants.COLUMNS; j++)
            {
                Console.Write(" --", Color.Green);
            }
            Console.WriteLine();

            for (int i = 0; i < Constants.ROWS; i++)
            {
                for (int j = 0; j < Constants.COLUMNS; j++)
                {
                    Console.Write("| " + grid[i, j] + " ", Color.Red);
                }
                Console.WriteLine("|", Color.Red);

                //Row separator
                for (int j = 0; j < Constants.COLUMNS; j++)
                {
                    Console.Write(" --", Color.Green);
                }
                Console.WriteLine();
            }
        }

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to Tic-Tac-Toe! Let's play!");
            Console.WriteLine();
        }

        public static char AskForSymbol()
        {
            Console.WriteLine($"What symbol would you like to be? \nPress {Constants.SYMBOL_CHOICE_O} or {Constants.SYMBOL_CHOICE_X}.");
            string input = Console.ReadLine()?.ToUpper();

            // User chooses a symbol
            while (input != Constants.SYMBOL_CHOICE_O.ToString() && input != Constants.SYMBOL_CHOICE_X.ToString())
            {
                Console.WriteLine("Incorrect input. Please try again.");
                input = Console.ReadLine()?.ToUpper();
            }

            char symbolChoice = input[0];
            Console.WriteLine($"You chose: {symbolChoice}");
            return symbolChoice;
        }

        // Ask user to choose a spot
        public static void AskForUserMove(char symbolChoice, string[,] grid)
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
                    if (row >= 0 && row < Constants.ROWS && column >= 0 && column < 3)
                    {
                        if (grid[row, column] == null)
                        {
                            grid[row, column] = symbolChoice.ToString();
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



    }
}