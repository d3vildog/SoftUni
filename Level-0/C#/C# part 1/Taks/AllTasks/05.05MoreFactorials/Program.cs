namespace _05._05MoreFactorials
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
           // Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
           
           // Declaring variables 
            int n;
            int k;
            int factN = 1;
            int factK = 1;
            int bothFact = 1;
            double result;

           // User input
            Console.Write("N = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            k = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }

            for (int i = 1; i <= k; i++)
            {
                factK *= i;
            }
            
           for (int i = 1; i <= k - n; i++)
			{
			    bothFact *= i;
			}

           result = (factN * factK) / (bothFact);
           Console.WriteLine(result);
           Console.WriteLine();
           Main();
        }
    }
}
