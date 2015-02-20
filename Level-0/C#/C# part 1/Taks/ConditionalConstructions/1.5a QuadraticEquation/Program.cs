using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5a_QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enters the coefficients a, b and c");
            Console.WriteLine("Of the quadratic equation a*x2 + b*x + c = 0");
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            double discriminant = Math.Pow(b, 2) -( 4 * a * c);
            Console.WriteLine("D = " + discriminant);

            double x1;
            double x2;
            if (discriminant > 0)
            {
                x1 = ((-b) + Math.Sqrt(discriminant)) / (2*a);
                x2 = ((-b) - Math.Sqrt(discriminant)) / (2*a);
                Console.WriteLine("D>1\n x1 = " + x1 + " x2 = " + x2);
            }
            else if (discriminant == 0)
            {
                x1 = x2 = (-b)  / (2*a);
                Console.WriteLine("D=0\n x1=x2 = " + x1);
            }
            else
            {
                Console.WriteLine("D<0 no real roots");
            }

            Console.ReadKey();
        }
    }
}
