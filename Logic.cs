namespace TTT
{
    class Logic
    {
        // Assigning a symbol to the computer
        public static char AssignComputerSymbol(char symbolChoice)
        {
            char computerSymbol;
            if (symbolChoice == Constants.SYMBOL_CHOICE_O)
            {
                computerSymbol = Constants.SYMBOL_CHOICE_X;

            }
            else
            {
                computerSymbol = Constants.SYMBOL_CHOICE_O;
            }
           
            Console.WriteLine($"Computer symbol is: {computerSymbol}");
            return computerSymbol;
        }

        //check if the grid is filled
        public static bool CheckIfFull(string[,] grid)
        {
            for (int row = 0; row < Constants.ROWS; row++)
            {
                for (int col = 0; col < Constants.COLUMNS; col++)
                {
                    if (grid[row, col] == " ")
                        return true;
                }
            }
            return false;
        }

        //check for a win
        public static bool CheckWin(string[,] grid)
        {
            return CheckHorizontalWin(grid) || CheckVerticalWin(grid) || CheckDiagonalWin1(grid) || CheckDiagonalWin2(grid);
        }
        //check for horizontal win
        public static bool CheckHorizontalWin(string[,] grid)
        {
            for (int row = 0; row < Constants.ROWS; row++)
            {
                if (grid[row, 0] == grid[row, 1] && grid[row, 1] == grid[row, 2] && grid[row, 0] != " ")
                {
                    return true;
                }
            }
            return false;
        }

        //check for vertical win
        public static bool CheckVerticalWin(string[,] grid)
        {
            for (int col = 0; col < Constants.COLUMNS; col++)
            {
                if (grid[0, col] == grid[1, col] && grid[1, col] == grid[2, col] && grid[0, col] != " ")
                {
                    return true;
                }
            }
            return false;
        }
        //check for diagonal win 1
        public static bool CheckDiagonalWin1(string[,] grid)
        {
            for (int row = 1; row < Constants.ROWS; row++)
            {
                if (grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2] && grid[0, 0] != " ")
                {
                    return true;
                }
            }
            return false;
        }
        //check for diagonal win 2
        public static bool CheckDiagonalWin2(string[,] grid)
        {
            for (int row = 1; row < Constants.ROWS; row++)
            {
                if (grid[0, 2] == grid[1, 1] && grid[1, 1] == grid[2, 0] && grid[0, 2] != " ")
                {
                    return true;
                }
            }
            return false;
        }       
        
        //create a grid
        public static string[,] CreateGrid()
        {
            string[,] grid = new string[Constants.ROWS, Constants.COLUMNS];

            for (int row = 0; row < Constants.ROWS; row++)
            {
                for (int col = 0; col < Constants.COLUMNS; col++)
                {
                    grid[row, col] = " ";
                }
            }
            return grid;
        
        }
        }
}






