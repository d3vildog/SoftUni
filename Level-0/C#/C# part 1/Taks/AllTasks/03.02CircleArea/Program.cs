namespace _03._02CircleArea
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
           // Declaring variables
           int radius;
           float area;
           const float pi = 3.14f;

           // User input
           Console.Write("Enter radius of the circle: ");
           radius = int.Parse(Console.ReadLine());

           // Solution 
           area = pi * (radius * radius);

           // Output
           Console.WriteLine("The circle are is {0}", area);
           Console.ReadKey();
        }
    }
}
