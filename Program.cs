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
            UI.PrintComputerSymbol(computerSymbol);           

            //Main game loop
            while (true)
            {
                if (Logic.CheckIfFull(grid) == false)
                {
                    // Ask user to choose a spot
                    UI.AskForUserMove(symbolChoice, grid);

                    //check for a win                 
                    if (Logic.CheckWin(grid) == true)
                    {
                        UI.PrintYouWinMessage();
                        break;
                    }
                }

                if (Logic.CheckIfFull(grid) == false)
                {
                    //Computer placing a symbol 
                    UI.PrintComputerTurnMessage();
                    Logic.GenerateComputerMove(grid, computerSymbol);

                    UI.PrintGrid(grid);
                    Console.WriteLine();

                    //check for a win
                    if (Logic.CheckWin(grid) == true)
                    {
                        UI.PrintComputerWinsMessage();
                        break;
                    }
                }

                else
                {
                    UI.PrintNoWinnerMessage();
                    break;
                }
            }
        }
    }
}
