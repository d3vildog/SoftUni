using System;

class Program
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());

        int height = (n * 2) - 1;
        int width = n + (n - 1);
        int arrowBodyHeight = n;
        int arrowBodyWidth = n;
        char[,] matrix = new char[height, width];

        // Fill the matrix with dots
        Fill(matrix, '.');

        // Constructing the arrow
        int startCol = n / 2;
        int endCol = width - (n / 2) - 1;
        int one = 0;
        int two = width - 1;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (row == 0 && column >= startCol && column <= endCol)
                {
                    matrix[row, column] = '#';
                }
                if (row < n && (column == startCol || column == endCol))
                {
                    matrix[row, column] = '#';
                }
                if (row == n - 1 && !(column >= n / 2 && column <= width - 1 - (n / 2)))
                {
                    matrix[row, column] = '#';
                }
                if (row >= n - 1)
                {
                    matrix[row, one] = '#';
                    matrix[row, two] = '#';
                }
            }
            if (row >= n - 1)
            {
                one++;
                two--;
            }
        }

        // Print the matrix on the console
        Print(matrix);
    }

    private static void Print(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    private static void Fill(char[,] matrix, char symbol)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = symbol;
            }
        }
    }
}