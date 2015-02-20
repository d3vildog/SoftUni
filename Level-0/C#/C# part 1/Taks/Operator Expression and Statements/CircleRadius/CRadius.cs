using System;

class CheckIfPointBelongToCircle
{
    static void Main()
    {
        double X;
        Console.WriteLine("Insert X coordinate:");
        bool checkX = double.TryParse(Console.ReadLine(),out X);
        double Y;
        Console.WriteLine("Insert Y coordinate:");
        bool checkY = double.TryParse(Console.ReadLine(), out Y);
        int radius = 5;
        if (checkY == true && checkX == true)
        {
            if ((X * X + Y * Y) < radius * radius)
                Console.WriteLine("Point ({0},{1}) is within circle K(0,5)", X, Y);
            else
                Console.WriteLine("Point ({0},{1}) is outside circle K(0,5)", X, Y);
        }
        //console.readline();
        //console.writeline("enter the \"x\" & \"y\" coordinates: ");
        //int x = int.parse(console.readline());
        //int y = int.parse(console.readline());
        //int cirleradius = 5;
        //bool result = x * x + y * y <= cirleradius * cirleradius;
        //console.writeline(result ? "the given cooredinates are within the circle" : "the given cooredinates are outside the circle");
    }
    }
}