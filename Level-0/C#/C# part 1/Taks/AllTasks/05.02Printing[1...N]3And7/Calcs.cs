namespace _05._02Printing_1._._.N_3And7
{
    using System;
    using System.Linq;

   public class Calcs
    {
       public static void Main()
        {
           // Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

           // Declaring variables
           string enteredValue;
           bool isCorrect;
           int number;

           // User input
           Console.Write("number = ");
           enteredValue = Console.ReadLine();
           isCorrect = int.TryParse(enteredValue, out number);

           // Solution
           if (isCorrect)
           {
               for (int i = 1; i <= number; i++)
               {
                   if (i % 3 != 0 && i % 7 != 0)
                   {
                       Console.Write(i + " ");
                   }
               }
           }
           else
           {
               Console.WriteLine("Incorrect input!!!");
           }

           Console.WriteLine();
           Main();
        }
    }
}
