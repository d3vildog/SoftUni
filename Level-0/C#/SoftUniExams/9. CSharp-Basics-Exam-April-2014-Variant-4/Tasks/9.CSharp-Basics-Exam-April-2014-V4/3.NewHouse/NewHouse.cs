using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int houseHeight = n;
        int houseWidth = n;
        int houseRoof = 2;
        int leftSide = 0;
        int rightSide = n - 1;        

        for (int i = 4; i <= n; i++)
        {
            if (i % 2 != 0)
            {
                houseRoof++;
            }
        }
        
        int totalHouseHeight = houseRoof + houseHeight;
        char[,] matrix = new char[totalHouseHeight, houseWidth];

        // Filling the matrix with *
        for (int row = 0; row < totalHouseHeight; row++)
        {
            for (int column = 0; column < houseWidth; column++)
            {
                matrix[row, column] = '*';
            }
        }

        // Making the house roof
        int perm = houseWidth / 2;
        for (int row = 0; row < houseRoof - 1; row++)
        {
            for (int col = 0; col < perm; col++)
            {
                matrix[row, col] = '-';
                matrix[row, rightSide] = '-';
                rightSide--;
            }
            rightSide = n - 1;
            perm--;
        }

        // Making house body
        int bodyRow = houseRoof;
        for (int i = 0; i < n; i++)
        {
            matrix[bodyRow, leftSide] = '|';
            matrix[bodyRow, rightSide] = '|';
            bodyRow++;
        }

        // Printing the matrix
        for (int row = 0; row < totalHouseHeight; row++)
        {
            for (int column = 0; column < houseWidth; column++)
            {
                Console.Write(matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}