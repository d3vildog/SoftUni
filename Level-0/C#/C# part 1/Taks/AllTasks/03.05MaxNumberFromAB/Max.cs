namespace _03._05MaxNumberFromAB
{
    using System;
    using System.Linq;

   public class Max
    {
       public static void Main()
        {
            // Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

           // User input
           System.Console.Write("Enter number = ");
           int firstNumber = int.Parse(Console.ReadLine());
           Console.Write("Enter second number = ");
           int secondNumber = int.Parse(Console.ReadLine());

           Console.WriteLine(firstNumber > secondNumber ? firstNumber : secondNumber);
           Console.WriteLine();
           Main();
        }
    }
}
