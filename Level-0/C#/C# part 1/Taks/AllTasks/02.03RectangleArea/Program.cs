using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._03RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int rectangleWidth;
            int rectangleHeight;

            //Input
            Console.Write("Enter the width of the rectangle: ");
            rectangleWidth = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of the rectangle: ");
            rectangleHeight = int.Parse(Console.ReadLine());

            //Rectangle Area formula
            int rectArea = rectangleWidth * rectangleHeight;

            //Output
            Console.WriteLine("The area of the rectangle is " + rectArea );

            Console.ReadLine();
        }
    }
}
