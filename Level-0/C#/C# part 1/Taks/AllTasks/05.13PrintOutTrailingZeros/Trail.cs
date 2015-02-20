namespace _05._13PrintOutTrailingZeros
{
    using System;
    using System.Linq;

   public class Trail
    {
       public static void Main()
        {
            // Write a program that calculates for given N how many trailing zeros present at the end of the number N!. 
            
            // User input
            Console.Write("N = ");
            int numberN = int.Parse(Console.ReadLine());
            long factorial = 1;
            int counter = 0;

            for (int i = 1; i <= numberN; i++)
            {
                factorial *= i;
            }

            for (int i = 1; i <= numberN; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("Factorial of {0} is {1} and it has {2} trailing zeros!", numberN, factorial, counter);
            Console.WriteLine();
            Main();
       }
    }
}
