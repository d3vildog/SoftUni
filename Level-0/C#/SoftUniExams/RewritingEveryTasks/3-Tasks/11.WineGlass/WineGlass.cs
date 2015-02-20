using System;

class WineGlass
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());

        int height = n;
        int width = n;
        int topHeight = n / 2;
        int padHeight = (n < 12 ? 1 : 2);
        char[,] matrix = new char[height, width]; 

        // Fill the matrix
        Fill(matrix);

        // The Glass Of Wine
        int start = 0;
        int end = width - 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            if (row < n / 2)
            {
                for (int column = start; column <= end; column++)
                {
                    if (column == start)
                    {
                        matrix[row, column] = '\\';
                    }
                    else if (column == end)
                    {
                        matrix[row, column] = '/';
                    }
                    else
                    {
                        matrix[row, column] = '*';
                    }
                }
                start++;
                end--;
            }
            else if (row >= n / 2)
            { 
                int col = n / 2 - 1;
                matrix[row, col] = '|';
                matrix[row, col + 1] = '|';

                if (row >= height - padHeight)
                {
                    for (int column = 0; column < matrix.GetLength(1); column++)
                    {
                        matrix[row, column] = '-';
                    }
                }
            }
        }

        // Print the matrix
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
                matrix[row, column] = '.';
            }
        }
    }
}