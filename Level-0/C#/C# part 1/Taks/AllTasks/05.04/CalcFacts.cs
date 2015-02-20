namespace _05._04
{
    using System;
    using System.Linq;

   public class CalcFacts
    {
       public static void Main()
        {
           //Write a program that calculates N!/K! for given N and K (1<K<N).
            int factorialN = 1;
            int factorialK = 1;
            double result;
           // User input
            Console.WriteLine("1 < K < N");
           Console.Write("K = ");
           int k = int.Parse(Console.ReadLine());
           Console.Write("N = ");
           int n = int.Parse(Console.ReadLine());

           for (int i = 1; i <= k; i++)
           {
               factorialK *= i;
           }

           for (int i = 1; i <= n; i++)
           {
               factorialN *= i;
           }

           Console.WriteLine("Factorial K = " + factorialK);
           Console.WriteLine("Factorial N = " + factorialN);
           result = factorialN / factorialK;
           Console.WriteLine("N!/K! = " + result);
           Console.WriteLine();
           Main();
       }
    }
}
