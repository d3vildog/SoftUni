namespace _04._11
{
    using System;
    using System.Linq;

   public class Numbers
    {
       public static void Main()
        {
            ////Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
            ////0  "Zero"
            ////273  "Two hundred seventy three"
            ////400  "Four hundred"
            ////501  "Five hundred and one"
            ////711  "Seven hundred and eleven

           int number;
           int digitNumber;
           int tenNumber;
           int hundredNumber;

           // User input
           Console.WriteLine("Enter number |[0...999]|");
           string input = Console.ReadLine();

           string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
           string[] tens = { " ", " ", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

           bool isRight = int.TryParse(input, out number);

           if (isRight)
           {
               if (number >= 0 && number <= 9)
               {
                   switch (number)
                   {
                       case 0:
                           Console.WriteLine(digits[0]);
                           break;
                       case 1:
                           Console.WriteLine(digits[1]);
                           break;
                       case 2:
                           Console.WriteLine(digits[2]);
                           break;
                       case 3:
                           Console.WriteLine(digits[3]);
                           break;
                       case 4:
                           Console.WriteLine(digits[4]);
                           break;
                       case 5:
                           Console.WriteLine(digits[5]);
                           break;
                       case 6:
                           Console.WriteLine(digits[6]);
                           break;
                       case 7:
                           Console.WriteLine(digits[7]);
                           break;
                       case 8:
                           Console.WriteLine(digits[8]);
                           break;
                       case 9:
                           Console.WriteLine(digits[9]);
                           break;
                       default:
                           Console.WriteLine("Wrong input!");
                           break;
                   }
               }
               else if (number >= 10 && number <= 19)
               {
                   switch (number)
                   {
                       case 10:
                           Console.WriteLine(digits[10]);
                           break;
                       case 11:
                           Console.WriteLine(digits[11]);
                           break;
                       case 12:
                           Console.WriteLine(digits[12]);
                           break;
                       case 13:
                           Console.WriteLine(digits[13]);
                           break;
                       case 14:
                           Console.WriteLine(digits[14]);
                           break;
                       case 15:
                           Console.WriteLine(digits[15]);
                           break;
                       case 16:
                           Console.WriteLine(digits[16]);
                           break;
                       case 17:
                           Console.WriteLine(digits[17]);
                           break;
                       case 18:
                           Console.WriteLine(digits[18]);
                           break;
                       case 19:
                           Console.WriteLine(digits[19]);
                           break;
                       default:
                           Console.WriteLine("Wrong input!");
                           break;
                   }
               }
               else if (number >= 20 && number <= 99)
               {
                   if (number % 10 != 0)
                   {
                       tenNumber = number / 10;
                       digitNumber = number % 10;
                       Console.WriteLine(tens[tenNumber] + " " + digits[digitNumber]);
                   }
                   else
                   {
                       tenNumber = number / 10;
                       Console.WriteLine(tens[tenNumber]);
                   }
               }
               else if (number >= 100 && number <= 999)
               {
                   hundredNumber = number / 100;
                   tenNumber = number / 10;
                   tenNumber = tenNumber % 10;
                   digitNumber = number % 10;
                   Console.WriteLine(digits[hundredNumber] + " hundred" + " and " + tens[tenNumber] + "-" + digits[digitNumber]);
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
