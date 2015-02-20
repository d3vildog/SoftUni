namespace _05._01PrintingNumbers_1._._.N_
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
           // Write a program that prints all the numbers from 1 to N.
           
           // User input
           Console.Write("Input number = ");
           int number = int.Parse(Console.ReadLine());

           for (int i = 1; i <= number; i++)
           {
               Console.Write(i + " ");
           }

           Console.WriteLine();
           Main(); 
       }
    }
}
