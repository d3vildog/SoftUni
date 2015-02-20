using System;

class NewHouse
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());

        int baseHeight = n;
        int roofHeight = (n / 2) + 1;
        int height = baseHeight + roofHeight;
        int width = n;
        char[,] matrix = new char[height, width];

        // Fill the house
        Fill(matrix);

        // House
        int start = n / 2 - 1;
        int end = n / 2 + 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if ( (column >= 0 && column <= start) || (column >= end && column <= width - 1))
                {
                    matrix[row, column] = '-';
                }
                if ( (row >= roofHeight && row <= height - 1) && (column == 0 || column == width - 1) )
                {
                    matrix[row, column] = '|';
                }
            }
            start--;
            end++;
        }

        // Print the house
        Print(matrix);
    }

    private static void Print(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int co = 0; co < matrix.GetLength(1); co++)
            {
                Console.Write(matrix[row, co]);
            }
            Console.WriteLine();
        }
    }

    private static void Fill(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int co = 0; co < matrix.GetLength(1); co++)
            {
                matrix[row, co] = '*';
            }
        }
    }
}