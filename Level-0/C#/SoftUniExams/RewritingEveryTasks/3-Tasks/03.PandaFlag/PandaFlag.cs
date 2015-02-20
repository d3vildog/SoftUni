using System;

class PandaFlag
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());

        int height = n;
        int width = n;
        char letter = 'A';
        int half = n / 2;
        char[,] matrix = new char[height, width];

        // Method for filling the matrix with '~'
        FillMatrix(matrix);

        // Making the Panda Scotland Flag
        int start = 0;
        int end = width - 1;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = start; column <= end; column++)
            {
                if (column == start || column == end)
                {
                    matrix[row, column] = letter;
                    letter++;
                    if (letter > 'Z')
                    {
                        letter = 'A';
                    }
                }
                else
                {
                    matrix[row, column] = '#';
                }
            }
            bool isRising = row >= half;

            if (!isRising)
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

    private static void FillMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = '~';
                if (row == matrix.GetLength(0) / 2)
                {
                    matrix[row, column] = '-';
                }
            }
        }
    }
}