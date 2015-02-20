using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {   //height
            Console.WriteLine("Enter the height of the triangle: ");
            int height = int.Parse(Console.ReadLine());

            //width
            Console.WriteLine("Enter the width of the triangle: ");
            int width = int.Parse(Console.ReadLine());

            int areaOfTheTriangle = height * width;

            Console.WriteLine("The are of the triangle is: " + areaOfTheTriangle);
            Console.ReadLine();
        }
    }
}
