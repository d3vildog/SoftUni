using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2PrintingAreaAndPerimeterOfCyrcle
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            Console.Write("Enter radius for the circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            // Begin timing
            stopwatch.Start();
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("The perimeter of a circle with radius {0} cm is {1:0.00} cm.", radius, perimeter);
 
            double area = Math.PI * (radius * radius);
            Console.WriteLine("The area of a circle with radius {0} cm is {1:0.00} cm.", radius, area);
            // Stop timing
            stopwatch.Stop();
            // Write result
            Console.WriteLine("Time elapsed: {0}",stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
