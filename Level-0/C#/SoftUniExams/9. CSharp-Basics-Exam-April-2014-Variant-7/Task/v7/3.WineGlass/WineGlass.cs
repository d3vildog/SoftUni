using System;
class WineGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int glassWidth = n;
        int glassHeight = n;
        int topPartRow = n / 2;


        char[,] matrix = new char[glassHeight, glassWidth];

        // Filling the matrix with .
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = '.';
            }
        }

        // The Glass top Part
        int leftSide = 0;
        int rightSide = n - 1;
        for (int row = 0; row < topPartRow; row++)
        {
            matrix[row, leftSide] = '\\';
            matrix[row, rightSide] = '/';
            leftSide++;
            rightSide--;
        }

        // The wine
        int col = 1;
        int lessCol = n - 2;
        for (int row = 0; row < topPartRow; row++)
        {
            for (int column = col; column <= lessCol; column++)
            {
                matrix[row, column] = '*';
            }
            col++;
            lessCol--;
        }

        // The stick
        leftSide = n / 2 - 1;
        rightSide = leftSide + 1;
        for (int row = n / 2; row < n; row++)
        {
            matrix[row, leftSide] = '|';
            matrix[row, rightSide] = '|';
        }

        if (n >= 12)
        {
            for (int row = n - 2; row < n; row++)
            {
                for (int column = 0; column < glassWidth; column++)
                {
                    matrix[row, column] = '-';
                }
            }
        }
        else
        {
            for (int row = n - 1; row < n; row++)
            {
                for (int column = 0; column < glassWidth; column++)
                {
                    matrix[row, column] = '-';
                }
            }
        }

        // Printing out the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                Console.Write(matrix[row, column]);
            }
            Console.WriteLine(
                );
        }
    }
}