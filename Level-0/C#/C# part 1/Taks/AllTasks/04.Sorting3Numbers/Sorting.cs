namespace _04.Sorting3Numbers
{
    using System;
    using System.Linq;

   public class Sorting
    {
       public static void Main()
        {
           ////Sort 3 real values in descending order using nested if statements.

           // Input
           Console.WriteLine("Enter 3 consecutive numbers - ");
           int firstNumber = int.Parse(Console.ReadLine());
           int secondNumber = int.Parse(Console.ReadLine());
           int thirdNumber = int.Parse(Console.ReadLine());
           int max = 0;
           int average = 0;
           int min = 0;

           // Solution
           if (firstNumber > secondNumber)
           {
               max = firstNumber;
               if (firstNumber > thirdNumber)
               {
                   max = firstNumber;
                   if (secondNumber > thirdNumber)
                   {
                       average = secondNumber;
                       min = thirdNumber;
                   }
                   else
                   {
                       average = thirdNumber;
                       min = secondNumber;
                   }
               }
               else
               {
                   max = thirdNumber;
                   average = firstNumber;
                   min = secondNumber;
               }
           }
           else
           {
               max = secondNumber;
               if (secondNumber > thirdNumber)
               {
                   max = secondNumber;
                   if (firstNumber > thirdNumber)
                   {
                       average = firstNumber;
                       min = thirdNumber;
                   }
               }
               else
               {
                   max = thirdNumber;
                   average = secondNumber;
                   min = firstNumber;
               }
           }

           Console.WriteLine("Max = {0} | Average = {1} | Min {2}", max, average, min);
           Console.WriteLine();
           Main();
        }
    }
}
