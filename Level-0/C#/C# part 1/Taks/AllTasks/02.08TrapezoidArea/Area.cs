namespace _02._08TrapezoidArea
{
    using System;
    using System.Linq;

   public class Area
    {
       public static void Main()
        {
           // Declaring variables
           int a;
           int b;
           int h;
           double area;

           // Input
           Console.Write("Enter value for a = ");
           a = int.Parse(Console.ReadLine());
           Console.Write("Enter value for b = ");
           b = int.Parse(Console.ReadLine());
           Console.Write("Enter value for h = ");
           h = int.Parse(Console.ReadLine());

           // Solution 
           area = ((a + b) * h) / 2;

           // Output
           Console.WriteLine("The area of this inputs is = " + area);
           Console.WriteLine();
           Main(); 
       }
    }
}
