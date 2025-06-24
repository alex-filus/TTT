using System.Data;
using Console = Colorful.Console;

namespace TTT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialize the grid
            string[,] grid = new string[Constants.ROWS, Constants.COLUMNS];

            //Welcome Message
            UI.PrintWelcomeMessage();

            char computerSymbol;

            UI.PrintGrid(grid);

            //User chooses symbol
            char symbolChoice = UI.AskForSymbol();

            //assign symbol to the computer
            computerSymbol = Logic.AssignComputerSymbol(symbolChoice);

            //Main game loop
            while (true)
            {
                if (Logic.CheckIfFull(grid) == true)
                {
                    // Ask user to choose a spot
                    UI.AskForUserMove(symbolChoice, grid);

                    //check for a win                 
                    if (Logic.CheckWin(grid) == true)
                    {
                        Console.WriteLine("Congrats! You win!");
                        break;
                    }
                }

                if (Logic.CheckIfFull(grid) == true)
                {
                    //Computer placing a symbol 
                    UI.PrintComputerTurnMessage();
                    UI.GenerateComputerMove(grid, computerSymbol);

                    //check for a win
                    if (Logic.CheckWin(grid) == true)
                    {
                        Console.WriteLine("Sorry, computer wins :(");
                        break;
                    }
                }

                else
                {
                    Console.WriteLine("Sorry, game over! No winner!");
                    break;
                }
            }
        }
    }
}
