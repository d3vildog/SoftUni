using System;

class Explorer
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());

        int height = n;
        int width = n;
        char[,] matrix = new char[height, width];

        // Fill the matrix
        Fill(matrix);

        // Making the diamond
        int start = n / 2;
        int end = n / 2;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (column == start || column == end)
                {
                    matrix[row, column] = '*';
                }
            }
            bool isRising = row >= n / 2;
            if (!isRising)
            {
                start--;
                end++;
            }
            else
            {
                start++;
                end--;
            }
        }

        // Print the matrix
        Print(matrix);
    }

    private static void Print(char[,] matrix)
    {    
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int colmn = 0; colmn < matrix.GetLength(1); colmn++)
            {
                Console.Write(matrix[row, colmn]);
            }
            Console.WriteLine();
        }
    }

    private static void Fill(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int colmn = 0; colmn < matrix.GetLength(1); colmn++)
            {
                matrix[row, colmn] = '-';
            }
        }
    }
}