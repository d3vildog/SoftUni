using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingTrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Enter side A
            Console.Write("Enter side A of the Trapezoid: ");
            float sideA = float.Parse(Console.ReadLine());
            //Enter side B
            Console.Write("Enter side B of the Trapezoid: ");
            float sideB = float.Parse(Console.ReadLine());
            //Enter Height
            Console.Write("Enter Height of the Trapezoid: ");
            float height = float.Parse(Console.ReadLine());

            float trapezoidArea = ((sideA + sideB) / 2) * height;

            Console.Write("The Trapezoid area is: " + trapezoidArea);
            Console.Read();
        }
    }
}
