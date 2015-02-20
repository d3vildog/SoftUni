namespace _03._01SummingThreeElements
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main(string[] args)
        {
            // Declaring variables
            int firstNum;
            int secondNum;
            int thirdNum;
            int result;

            // User input
            Console.Write("Enter first number = ");
            firstNum = int.Parse(Console.ReadLine());
            Console.Write("Enter second number = ");
            secondNum = int.Parse(Console.ReadLine());
            Console.Write("Enter third number = ");
            thirdNum = int.Parse(Console.ReadLine());

            // Solution
            result = firstNum + secondNum + thirdNum;

            // Output
            Console.WriteLine("The sum of this 3 elements is: {0}", result);
            Console.ReadKey();
        }
    }
}
