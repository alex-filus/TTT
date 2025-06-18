using System;
using System.Drawing;
using Console = Colorful.Console;
using System.Threading;
using TTT;

namespace TTT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] grid =
         {
            { " ", " ", " " },
            { " ", " ", " " },
            { " ", " ", " " }
        };


            //Welcome Message
            UI.DisplayWelcomeMessage();

            string computerSymbol = " ";           

            UI.PrintGrid(grid);

            //User chooses symbol
            string symbolChoice = UI.AskUserForSymbol();

            //assign symbol to the computer
            Logic.ComputerSymbolAssign(symbolChoice);

            //Main game loop
            while (true)
            {
                if (Logic.NotFull(grid) == true)
                {
                    // Ask user to choose a spot
                    UI.UserTurn(symbolChoice, grid);

                    //check for a win                 
                    if (Logic.WinCheck(grid) == true)
                    {
                        Console.WriteLine("Congrats! You win!");
                        break;
                    }
                }

                if (Logic.NotFull(grid) == true)
                {
                    //Computer placing a symbol 
                    UI.PrintComputerTurnMessage();
                    UI.ComputerTurn(grid, computerSymbol);

                    //check for a win
                    if (Logic.WinCheck(grid) == true)
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
