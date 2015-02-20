using System;

class SandGlass
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());

        int height = n;
        int width = n;
        int half = n / 2;
        char[,] matrix = new char[height, width];

        // Method for filling the matrix with given Char('.')
        Fill('.', matrix);

        // Making the sand glass
        int start = 0;
        int end = width - 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = start; column <= end; column++)
            {
                matrix[row, column] = '*';
            }
            bool NotRising = row < half;
            if (NotRising)
            {
                start++;
                end--;
            }
            else
            {
                start--;
                end++;
            }
        }

        // Method for printing the matrix on the console
        PrintMatrix(matrix);
    }

    private static void PrintMatrix(char[,] matrix)
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

    private static void Fill(char symbol, char[,] matrix)
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
