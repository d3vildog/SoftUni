namespace _03._08OuputingNNumbersInLane
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main(string[] args)
        {
        // Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
           Console.Write("Enter number = ");
           int number = int.Parse(Console.ReadLine());

           for (int i = 1; i <= number; i++)
           {
               Console.Write(i == number ? (i + "...") : (i + ", "));
           }

           Console.ReadKey();
       }
    }
}
