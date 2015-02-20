using System;

class HouseWithaWindow
{
    static void Main()
    {
        // User input N 
        int n = int.Parse(Console.ReadLine());

        // house and window variables
        int houseWidth = (2 * n) - 1;
        int houseHeight = (2 * n) + 2;
        int roofHeight = n;
        int baseHeight = n + 2;
        int windowHeight = n / 2;
        int windowWidth = n - 3;
        int leftSide = houseWidth / 2;
        int rightSide = houseWidth / 2;

        // Matrix
        char[,] matrix = new char[houseHeight, houseWidth];

        // Filling the house with dots '.'
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = '.';
            }
        }

        // Making the house roof
        for (int roofRow = 0; roofRow < roofHeight; roofRow++)
        {
            matrix[roofRow, leftSide] = '*';
            matrix[roofRow, rightSide] = '*';
            leftSide--;
            rightSide++;
        }

        // Making house Base 
        for (int row = roofHeight; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (row == roofHeight || row == houseHeight - 1)
                {
                    matrix[row, column] = '*';
                }
                if (column == 0 || column == houseWidth - 1)
                {
                    matrix[row, column] = '*';
                }
                if (row >= (roofHeight + 1 + ((n / 2) / 2)) && row <= (houseHeight - 2 -((n / 2) / 2)) && column >= ((n / 2) + 1) && column <= (houseWidth - (n / 2) - 2))
                {
                    matrix[row, column] = '*';
                }
            }
        }

        // Printing the matrix on the console
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