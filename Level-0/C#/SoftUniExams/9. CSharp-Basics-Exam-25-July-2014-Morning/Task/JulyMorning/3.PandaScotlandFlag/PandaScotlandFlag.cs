using System;

class PandaScotlandFlag
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[,] matrix = new char[n, n];

        // Fill the matrix with ~
        for (int row = 0; row < n; row++)
        {
            for (int column = 0; column < n; column++)
            {
                matrix[row, column] = '~';
                if (row == n / 2)
                {
                    matrix[row, column] = '-';
                }
            }
        }

        // Filling the sandGlass
        int wave = 0;
        int startingPoint;
        int endingPoint;
        char letter = 'A';
        for (int row = 0; row < n; row++)
        {
            startingPoint = n - (n - wave);
            endingPoint = n - wave;
            for (int column = startingPoint; column < endingPoint; column++)
            {
                matrix[row, column] = '#';
                if (column == wave || column == endingPoint - 1)
                {
                    matrix[row, column] = letter;
                    letter++;
                    if (letter > 'Z')
                    {
                        letter = 'A';
                    }
                }
            }

            if (row >= 0 && row < n / 2) 
            {
                wave++;
            }
            else 
            {
                wave--;
            }
        }

        // Printing the matrix
        for (int row = 0; row < n; row++)
        {
            for (int column = 0; column < n; column++)
            {
                Console.Write(matrix[row, column]);
            }
            Console.WriteLine();
        }
    }
}