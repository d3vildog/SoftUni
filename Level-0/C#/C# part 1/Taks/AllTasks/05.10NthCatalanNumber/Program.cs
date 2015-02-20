namespace _05._10NthCatalanNumber
{
    using System;
    using System.Linq;
    
   public class Program
    {
       public static int Factorial(int number)
       {
           int result = 1;

           for (int i = 1; i <= number; i++)
           {
               result *= i;
           }

           return result;
       }

       public static void Main()
       {
           //// Cn = (2n)! / (n + 1)! * n! for n >= 0  
           // Declaring Variables 
           int N;

           // User input
           Console.WriteLine("n >= 0");
           Console.Write("Enter n = ");
           N = int.Parse(Console.ReadLine());

           // Solution
           double[] catalanNumber = new double[N];

           catalanNumber[N - 1] = Factorial(2 * N) / (Factorial(N + 1) * Factorial(N)); ;

           Console.WriteLine(catalanNumber.GetValue(N - 1));
           Console.ReadLine();
       }
    }
    
}
