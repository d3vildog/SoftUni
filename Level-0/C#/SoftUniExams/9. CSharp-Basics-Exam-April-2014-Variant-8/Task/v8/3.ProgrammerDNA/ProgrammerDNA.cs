using System;

class ProgrammerDNA
{
    static void Main()
    {
        int dnaLength = int.Parse(Console.ReadLine());
        char letter = char.Parse(Console.ReadLine());
        int dnaSize = 7;
        int beginning = 3;
        int end = 3;
        bool twice = true;
        bool isRising = true;
        char[,] matrix = new char[dnaLength, dnaSize];
        
        // Fill the matrix with .
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                matrix[row, column] = '.';
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int column = beginning; column <= end; column++)
            {
                matrix[row, column] = letter;
                if (letter >= 'A' && letter < 'G')
                {
                    letter++;
                }
                else
                {
                    letter = 'A';
                }
            }
            if (beginning == 3 && end == 3 && twice && row != 0)
            {
                twice = !twice;
                continue;
            }
            else if (isRising)
            {
                beginning--;
                end++;
                if (beginning <= 0 && end >= 6)
	            {
                    isRising = false;
	            }
            }
            else if(!isRising)
            {
                beginning++;
                end--;
                if (beginning == 3 && end == 3)
                {
                    twice = true;
                    isRising = true;
                }
            }
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