using System;

class House
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());

        int height = n;
        int width = n;
        int startCol = n / 2;
        int endCol = n / 2;
        char[,] matrix = new char[height, width];
        
        // Fill the matrix
        Fill(matrix);

        // Building the house
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (column == startCol || column == endCol)
                {
                    matrix[row, column] = '*';
                }
                if (row == n / 2 || (row == height - 1  && (column >= n / 4 && column <= width - (n / 4) - 1)))
                {
                    matrix[row, column] = '*';
                }
            }
            if (row < n / 2)
            {
                startCol--;
                endCol++;
            }
            else
            {
                startCol = n / 4;
                endCol = width - (n / 4) - 1; 
            }
        }

        // Print the matrix
        Print(matrix);
    }

    private static void Print(char[,] matrix)
    {
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                Console.Write(matrix[r, c]);
            }
            Console.WriteLine();
        }
    }

    private static void Fill(char[,] matrix)
    {
        for (int r = 0; r < matrix.GetLength(0); r++)
        {
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                matrix[r, c] = '.';
            }
        }
    }
}