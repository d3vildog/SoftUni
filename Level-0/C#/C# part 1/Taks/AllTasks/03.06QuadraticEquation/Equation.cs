namespace _03._06QuadraticEquation
{
    using System;
    using System.Linq;

   public class Equation
    {
       public static void Main()
        {
            // Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

            // User input
            Console.Write("Input value for a: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Input value for b: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Input value for c: ");
            double c = int.Parse(Console.ReadLine());
            double x1;
            double x2;
            double discriminant = (b * b) - (4 * a * c);

            if (discriminant > 0)
            {
                 x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                 x2 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                 Console.WriteLine(x1 + " and " + x2);
            }
            else if (discriminant == 0)
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("x1 = x2 = " + x1);
            }
            else
            {
                Console.WriteLine("No real roots!");
            }

            Main();
        }
    }
}
