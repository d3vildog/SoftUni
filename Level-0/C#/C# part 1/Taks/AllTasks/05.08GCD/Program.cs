namespace _05._08GCD
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
            //Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).
           int a = 8;
           int b = 12;

           for (int i = 10; i >= 1; i--)
           {
               if (a % i == 0 && b % i == 0)
               {
                   Console.WriteLine(i);
                   break;
               }
           }

           Console.WriteLine();
           Console.ReadKey();
       }
    }
}
