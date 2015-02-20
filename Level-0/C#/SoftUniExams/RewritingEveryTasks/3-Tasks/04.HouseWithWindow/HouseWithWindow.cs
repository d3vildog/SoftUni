using System;

class HouseWithWindow
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());

        int width = (2 * n) - 1;
        int height = (2 * n) + 2;
        int roofHeight = n;
        int baseHeight = n + 2;

        int windowHeight = n / 2;
        int windowWidth = n - 3;

        char symbol = '*';
        char[,] matrix = new char[height, width];

        // Method for filling the matrix with DOTS
        FillTheMatrix(matrix);

        // Making the house
        int startCol = width / 2;
        int endCol = width / 2;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (column == startCol || column == endCol || row == height - 1 || row == roofHeight)
                {
                    matrix[row, column] = symbol;
                }
                if ((column == 0 || column == width - 1) && row >= roofHeight)
                {
                    matrix[row, column] = symbol;
                }
                if (((row > roofHeight + (n / 4)) &&
                    (row <= roofHeight + (n / 4) + windowHeight)) &&
                    (column >= (n / 2) + 1) && column < (n / 2) + 1 + windowWidth)
                {
                    matrix[row, column] = symbol;
                }
            }
            startCol--;
            endCol++;
        }

        // Method for printing the matrix on the console
        PrintTheMatrix(matrix);
    }

    private static void PrintTheMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                Console.Write(matrix[row, column]);
            }
            Console.WriteLine();
        }
    }

    private static void FillTheMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = '.';
            }
        }
    }
}