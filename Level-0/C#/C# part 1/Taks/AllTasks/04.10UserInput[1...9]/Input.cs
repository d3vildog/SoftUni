namespace _04._10UserInput_1._._._9_
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
            //Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.

           // User input
            Console.WriteLine("Enter number from 1 to 9!!!");
            int digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("The number {0} is multiplied by 10 = {1}", digit, digit * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("The number {0} is multiplied by 100 = {1}", digit, digit * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("The number {0} is multiplied by 1000 = {1}", digit, digit * 1000);
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

            Console.WriteLine();
            Main();
        }
    }
}
