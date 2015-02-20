namespace _04._06QuadricEquasion
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main(string[] args)
        {
           /* Write a program that enters the coefficients a, b and c of a quadratic equation
		   /* a*x2 + b*x + c = 0*/

           // User input 
           Console.Write("a = ");
           double a = double.Parse(Console.ReadLine());
           Console.Write("b = ");
           double b = double.Parse(Console.ReadLine());
           Console.Write("c = ");
           double c = double.Parse(Console.ReadLine());

           double x1;
           double x2;
           double discriminant;
           discriminant = (b * b) - (4 * a * a);

           if (discriminant > 0)
           {
               x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
               x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
               Console.WriteLine("D > 0 | x1 = {0} and x2 = {1}", x1, x2);
           }
           else if (discriminant == 0)
           {
               x1 = x2 = -b / (2 * a);
               Console.WriteLine("D = 0 | x1 = x2 = {0}", x1);
           }
           else
           {
               Console.WriteLine("There are no real roots");
           }
           
           Console.ReadKey();
       }
    }
}
