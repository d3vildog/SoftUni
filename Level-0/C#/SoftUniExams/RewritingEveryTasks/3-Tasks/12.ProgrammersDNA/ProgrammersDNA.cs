using System;

class ProgrammerDNA
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());

        // Declaring variables
        int height = n;
        int width = 7;
        char[,] matrix = new char[height, width];

        // Filling the matrix with dots
        for (int row = 0; row < height; row++)
        {
            for (int column = 0; column < width; column++)
            {
                matrix[row, column] = '.';
            }
        }

        int start = width / 2;
        int end = width / 2;
        bool isRising = true;
        bool twice = false;
        for (int row = 0; row < height; row++)
        {
            for (int column = start; column <= end; column++)
            {
                matrix[row, column] = letter;
                letter++;
                if (letter > 'G')
                {
                    letter = 'A';
                }
            }
            if (start == width / 2 && twice && row != 0)
            {
                twice = !twice;
                continue;
            }
            else if (isRising)
            {
                start--;
                end++;
                if (start == 0)
                {
                    isRising = false;
                }
            }
            else if (!isRising)
            {
                start++;
                end--;
                if (start == width / 2)
                {
                    twice = !twice;
                    isRising = true;
                }
            }
        }

        // Printing the matrix on the console
        for (int row = 0; row < height; row++)
        {
            for (int column = 0; column < width; column++)
            {
                Console.Write(matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}