namespace _05._09
{
    using System;
    using System.Linq;

   public class Catalan
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
           double catalanNumber;

           // User input
           Console.WriteLine("n >= 0");
           Console.Write("Enter n = ");
           N = int.Parse(Console.ReadLine());

           // Solution

           catalanNumber = Factorial(2 * N) / (Factorial(N + 1) * Factorial(N));

           Console.WriteLine(catalanNumber);
           Console.ReadLine();
       }
    }
}
