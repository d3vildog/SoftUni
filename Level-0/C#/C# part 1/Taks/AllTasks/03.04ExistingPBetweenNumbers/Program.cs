namespace _03._04ExistingPBetweenNumbers
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
          // Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
          // Declaring variables
           int firstNumber;
           int secondNumber;
           int counter = 0;
           int divider = 5;

           // User input
           Console.Write("Enter first number = ");
           firstNumber = int.Parse(Console.ReadLine());
           Console.Write("Enter second number = ");
           secondNumber = int.Parse(Console.ReadLine());

           for (int i = firstNumber; i <= secondNumber; i++)
           {
               if (i % divider == 0)
               {
                   counter++;
               }
           }

           Console.WriteLine("(( {0} - {1} ))= {2}", firstNumber, secondNumber, counter);
           Main();
       }
    }
}
