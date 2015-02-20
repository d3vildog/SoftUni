namespace _05._03Max_MinOfNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
           // Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.
           int currentValue;
           string inputedValue;
           int number;
           bool isChecked;
           List<int> numbers = new List<int>();

           while (true)
           {
               Console.Write("Enter number or write stop to see the result = ");
               inputedValue = Console.ReadLine();
               isChecked = int.TryParse(inputedValue, out number);

               if (isChecked)
               {
                   numbers.Add(number);
               }
               else if (inputedValue == "stop")
               {
                   break;
               }
               else
               {
                   Console.WriteLine("Incorrect input!!!");
               }
           }

           Console.WriteLine("Max value = {0}\nMin value = {1}", numbers.Max(), numbers.Min());
           Console.WriteLine();
           Main();
        }
    }
}
