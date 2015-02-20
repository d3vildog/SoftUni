using System;

class Eclipse
{
    static void Main()
    {
        // User input and variables
        int n = int.Parse(Console.ReadLine());

        int height = n;
        int width = (4 * n) + n - 1;

        char[,] matrix = new char[height, width];

        // Fill the matrix with empty spaces
        Fill(matrix);

        // Make the shining glasses
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (((row == 0 || row == height - 1) && !(column >= n * 2 && column <= n * 2 + n)) ||
                      (column == 0 || column == n * 2 - 1 || column == n * 2 + n || column == width - 1))
                {
                    matrix[row, column] = '*';
                }
                if (row == n / 2 && (column >= n * 2 && column < n * 2 + n))
                {
                    matrix[row, column] = '-';
                }
                if (row >= 1 && row < height - 1 && ((column >= 1 && column <= n * 2 - 2) || (column > n * 2 + n && column <= width - 2)))
                {
                    matrix[row, column] = '/';
                }
                if ( (row == 0 || row == height - 1) && (column == 0 || column == n*2 - 1 || column == n*2 + n || column == width - 1) )
                {
                    matrix[row, column] = ' ';
                }
            }
        }

        // Print the matrix on the console
        Print(matrix);
    }

    private static void Print(char[,] matrix)
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

    private static void Fill(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = ' ';
            }
        }
    }
}