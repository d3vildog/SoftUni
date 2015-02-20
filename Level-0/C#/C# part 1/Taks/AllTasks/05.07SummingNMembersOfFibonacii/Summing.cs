namespace _05._07SummingNMembersOfFibonacii
{
    using System;
    using System.Linq;

   public class Summing
    {
       public static void Main()
        {
           // Write a program that reads a number N and calculates the sum of the first N members of the sequence of    fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

           // User input
           Console.Write("N = ");
           int n = int.Parse(Console.ReadLine());
           int[] fibonacciNumbers = new int[n];
           fibonacciNumbers[0] = 0;
           fibonacciNumbers[1] = 1;

           // Solution
           for (int i = 2; i < fibonacciNumbers.Length; i++)
           {
               fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
           }

           // Output
           Console.WriteLine(fibonacciNumbers.Sum());
           Console.WriteLine();
           Main();
        }
    }
}
