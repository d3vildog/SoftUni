namespace _03._09FibonaciSequence
{
    using System;
    using System.Linq;

   public class Sequence
    {
       public static void Main(string[] args)
        {
            //// Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

            long[] fibonacciNumbers = new long[100];
            fibonacciNumbers[0] = 0;
            fibonacciNumbers[1] = 1;

            for (int i = 2; i < fibonacciNumbers.Length; i++)
            {
                fibonacciNumbers[i] = fibonacciNumbers[i - 1] + fibonacciNumbers[i - 2];
            }

            foreach (var fibonacci in fibonacciNumbers)
            {
                Console.WriteLine(fibonacci);
            }

            Console.ReadKey();
        }
    }
}
