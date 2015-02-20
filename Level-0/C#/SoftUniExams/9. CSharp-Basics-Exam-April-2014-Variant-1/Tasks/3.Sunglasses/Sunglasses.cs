using System;
using System.Linq;

class Sunglasses
{
    static void Main()
    {
        // User input and initializing variables
        int n = int.Parse(Console.ReadLine());
        int frameHeight = n;  //*
        int frameWidth = frameHeight * 2; //*
        int numberOfLensRows = n - 2; // /
        int bridge = n; // |
        int areaWidth = frameWidth * 2 + n;
        int topRow = 0;
        int bottomRow = frameHeight - 1;
        int topAndBottomFrames = 2;
        int numberOfLensColumns = frameWidth - 2;
        char[,] matrix = new char[n, areaWidth];

        // Filling the matrix with empty spaces
        for (int row = 0; row < frameHeight; row++)
        {
            for (int column = 0; column < areaWidth; column++)
            {
                matrix[row, column] = ' ';
            }
        }

        // Creating top and bottom frames
        for (int i = 0; i < topAndBottomFrames; i++)
        {
            for (int j = 0; j < areaWidth; j++)
            {
                if(j < frameWidth || j>= frameWidth + n)
                {
                    matrix[topRow, j] = '*';
                    matrix[bottomRow, j] = '*';
                }
            }
        }

        // Creating left and right frames and creating the frame bridge
        for (int row = 0; row < frameHeight; row++)
        {
            for (int column = 0; column < areaWidth; column++)
            {
                if (column == 0 || column == frameWidth - 1 || column == frameWidth + n || column == areaWidth - 1)
                {
                    matrix[row, column] = '*';
                }
                if (column >= frameWidth && column <= frameWidth + (n - 1) && row ==  n / 2)
                {
                    matrix[row, column] = '|';
                }
            }
        }

        // Creating the lens of the glasses
        int rightFrameLensColumn = frameWidth + bridge + 1;
        for (int row = 1; row <= numberOfLensRows; row++)
        {
            for (int column = 1; column <= numberOfLensColumns; column++)
            {
                matrix[row, column] = '/';
                matrix[row, rightFrameLensColumn] = '/';
                rightFrameLensColumn++;
            }
            rightFrameLensColumn = frameWidth + bridge + 1;
        }

        // Printing the matrix 
        for (int row = 0; row < frameHeight; row++)
        {
            for (int column = 0; column < areaWidth; column++)
            {
                Console.Write(matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}