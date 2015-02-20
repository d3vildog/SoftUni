using System;

class TheExplorer
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());
        int diamondWidth = n;
        int diamondHeight = n;
        int topRow = 0;
        int bottomRow = diamondHeight - 1;
        int center = n / 2;
        int leftSide = center;
        int rightSide = center;
        char[,] matrix = new char[diamondHeight, diamondWidth];
 
        // Filling the matrix with -
        for (int row = 0; row < diamondHeight; row++)
        {
            for (int column = 0; column < diamondWidth; column++)
            {
                matrix[row, column] = '-';
            }
        }

        // Making the diamond
        for (int i = 0; i <= center; i++)
        {
            matrix[topRow, leftSide] = '*';
            matrix[topRow, rightSide] = '*';
            matrix[bottomRow, leftSide] = '*';
            matrix[bottomRow, rightSide] = '*';
            topRow++;
            bottomRow--;
            leftSide--;
            rightSide++;
        }

        // Printing the diamond matrix
        for (int row = 0; row < diamondHeight; row++)
        {
            for (int column = 0; column < diamondWidth; column++)
            {
                Console.Write(matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}