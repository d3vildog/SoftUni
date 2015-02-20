using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the value of a: ");
            int coefficientA = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of b: ");
            int coefficientB = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of c: ");
            int coefficientC = int.Parse(Console.ReadLine());

            int x1;
            int x2;
            int discriminant = ((int)Math.Pow(coefficientB, 2)) - (4 * coefficientA * coefficientC);


            if (discriminant > 0)
            {
                x1 = ((-coefficientB) + (int)Math.Sqrt(discriminant)) / 2;
                x2 = ((-coefficientB) - (int)Math.Sqrt(discriminant)) / 2;
                Console.WriteLine(x1 + "\n" + x2);
            }
            else if (discriminant == 0)
            {
                x1 = x2 = ((-coefficientB) / 2);
                Console.WriteLine(x1);
            }
            else
            {
                Console.WriteLine("Nqma realni koreni");
            }



        }
    }
}
