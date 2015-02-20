namespace _05._06SomeFormula
{
    using System;
    using System.Linq;

   public class Program
    {
       public static int factorial(int numb)
       {
           int result = 1;
           for (int i = 1; i <= numb; i++)
           {
               result *= i;
           }
           return result;
       }

       public static void Main(string[] args)
        {
           // Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … +N!/X^N
            double sum = 1;
           while(true)
           {
               // User input;
               Console.Write("X = ");
               double x = double.Parse(Console.ReadLine());
               Console.Write("N = ");
               double n = double.Parse(Console.ReadLine());
           
               // Solution
               for (int i = 1; i <= n; i++)
               {
                   sum +=factorial(i) / Math.Pow(x, i);
               }

               // Output
               Console.WriteLine("S = 1 + 1!/X + 2!/X2 + … +N!/X^N");
               Console.WriteLine(sum);
               Console.WriteLine();
           }
        }
    }
}
