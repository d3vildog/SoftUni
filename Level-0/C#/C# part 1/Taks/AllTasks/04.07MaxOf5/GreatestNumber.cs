namespace _04._07MaxOf5
{
    using System;
    using System.Linq;

   public class GreatestNumber
    {
       public static void Main()
        {
           ////Write a program that finds the greatest of given 5 variables.
           
           // User input
           int[] number = new int[5];

           Console.WriteLine("Enter 5 consecutive numbers...");
           for (int i = 0; i < number.Length; i++)
           {
               number[i] = int.Parse(Console.ReadLine());
           }

           Console.WriteLine("The greatest number is " + number.Max());
           Console.WriteLine();
           Main(); 
       }
    }
}
