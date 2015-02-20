using System;

class CartesianCoordinateSystem
{
    static void Main()
    {
        // Input
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());
        int? location = null;

        // Solution

        if (y == 0 && x == 0)
        {
            location = 0;
        }
        else if (y > 0 && x > 0)
        {
            location = 1;
        }
        else if (y > 0 && x < 0)
        {
            location = 2;
        }
        else if (y < 0 && x < 0)
        {
            location = 3;
        }
        else if (y < 0 && x > 0)
        {
            location = 4;
        }
        else if (x == 0)
        {
            location = 5;
        }
        else if (y == 0)
        {
            location = 6;
        }

        Console.WriteLine(location);
    }
}