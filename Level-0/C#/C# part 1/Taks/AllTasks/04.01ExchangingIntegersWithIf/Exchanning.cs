namespace _04._01ExchangingIntegersWithIf
{
    using System;
    using System.Linq;
    using System.Threading;

   public class Exchanning
    {
       public static void Main()
        {
           //Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.
           // Declaring variables
           int firstNumber;
           int secondNumber;
           int max;

           // User input
           Console.WriteLine("Enter two numbers but second must be bigger than the first one!");
           Console.Write("first number = ");
           firstNumber = int.Parse(Console.ReadLine());
           Console.Write("second number = ");
           secondNumber = int.Parse(Console.ReadLine());

           // Solution
           if (firstNumber > secondNumber)
           {
               Console.WriteLine("Nah we have to change it...");
               Console.WriteLine("Wait until we exchange the values...");
               max = firstNumber;
               firstNumber = secondNumber;
               secondNumber = max;
               Thread.Sleep(500);
               Console.Beep();
               Console.WriteLine("first number = " + firstNumber);
               Thread.Sleep(100);
               Console.Beep();
               Console.WriteLine("second number = " + secondNumber);
           }
           else
           {
               Console.WriteLine("Everything is alright!");
           }
           Console.WriteLine();
           Main();
        }
    }
}
