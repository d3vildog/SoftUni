using System;

class Arrow
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int arrowTailWidth = n;
        int arrowTailHeight = n - 1;

        int arrowWidth = (2 * n) - 1;
        int arrowHeight = n;

        int totalArrowWidth = arrowWidth;
        int totalArrowHeight = arrowTailHeight + arrowHeight;

        char[,] matrix = new char[totalArrowHeight, totalArrowWidth];

        // Fill the matrix with .
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = '.';
            }
        }

        // Making arrow tail
        int leftColumn = (n / 2);
        int rightColumn = leftColumn + n - 1;
        for (int row = 0; row < arrowHeight; row++)
        {
            matrix[row, leftColumn] = '#';
            matrix[row, rightColumn] = '#';
        }

        // Top tail line 
        int roww = 0;
        for (int col = 0; col < arrowTailWidth; col++)
        {
            matrix[roww, leftColumn] = '#';
            leftColumn++;
        }

        // Arrow big line
        roww = n - 1;
        leftColumn = n / 2;
        for (int coll = 0; coll < leftColumn; coll++)
        {
            matrix[roww, coll] = '#';
            matrix[roww, rightColumn] = '#';
            rightColumn++;
        }

        // Making the arrow
        leftColumn = 0;
        rightColumn = 2 * n - 2;
        for (int rowww = 0; rowww < arrowHeight; rowww++)
        {
            matrix[roww, leftColumn] = '#';
            matrix[roww, rightColumn] = '#';
            roww++;
            leftColumn++;
            rightColumn--;
        }        

        // Print the matrix
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