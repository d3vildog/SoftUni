using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int houseHeight = n;
        int houseWidth = n;
        int houseWall = n / 4;
        int leftSide = n / 2;
        int rightSide = n / 2;
        char[,] matrix = new char[houseHeight, houseWidth];

        // Filling the house with .
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = '.';
            }
        }

        for (int row = 0; row < ((n + 1) / 2); row++)
        {
            matrix[row, leftSide] = '*';
            matrix[row, rightSide] = '*';
            leftSide--;
            rightSide++;
        }

        int roW = n / 2;
        for (int column = 0; column < n; column++)
        {
            matrix[roW, column] = '*';
        }

        int leftColumn = houseWall;
        int rightColumn = houseWidth - houseWall - 1;
        for (int row = (n/2); row < n; row++)
        {
            matrix[row, leftColumn] = '*';
            matrix[row, rightColumn] = '*';
        }

        for (int column = leftColumn; column < rightColumn; column++)
        {
            matrix[n - 1, column] = '*';
        }

        // Printing the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                Console.Write(matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}