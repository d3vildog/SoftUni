using System;

class Eclipse
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());
        int frameHeight = n - 2;
        int frameWidth = n * 2 - 2;
        int lensHeight = n - 2;
        int lensWidth = n * 2 - 2;
        int bridge = n - 1;
        int totalAreaWidth = frameWidth * 2 + bridge + 4;
        int topRow = 1;
        int bottomRow = frameHeight + 1;
        int leftColumn = 0;
        int rightColumn = frameWidth + bridge + 2;
        char[,] matrix = new char[frameHeight + 2, totalAreaWidth];

        // Filling the matrix with empty spaces
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = ' ';
            }
        }

        // Creating left and right frames
        for (int i = 0; i < frameHeight; i++)
        {
            matrix[topRow, leftColumn] = '*';
            matrix[topRow, rightColumn] = '*';
            topRow++;
        }

        // left and right
        topRow = 1;
        leftColumn = frameWidth + 1;
        rightColumn = totalAreaWidth - 1;
        for (int i = 0; i < frameHeight; i++)
        {
            matrix[topRow, leftColumn] = '*';
            matrix[topRow, rightColumn] = '*';
            topRow++;
        }

        // Creating top and bottom height
        topRow = 0;
        leftColumn = 1;
        rightColumn = frameWidth + bridge + 3;
        for (int i = 0; i < frameWidth; i++)
        {
            matrix[topRow, leftColumn] = '*';
            matrix[bottomRow, leftColumn] = '*';
            leftColumn++;
            matrix[topRow, rightColumn] = '*';
            matrix[bottomRow, rightColumn] = '*';
            rightColumn++;
        }

        // Bridge
        leftColumn = frameWidth + 2;
        topRow = n / 2;
        for (int i = 0; i < bridge; i++)
        {
            matrix[topRow, leftColumn] = '-';
            leftColumn++;
        }

        // Frame lens
        rightColumn = frameWidth + 3 + bridge;
        for (int row = 1; row <= lensHeight; row++)
        {
            for (int column = 1; column <= lensWidth; column++)
            {
                matrix[row, column] = '/';
                matrix[row, rightColumn] = '/';
                rightColumn++;
            }
            rightColumn = frameWidth + 3 + bridge;
        }

        // Printing the matrix;
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