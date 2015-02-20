using System;

class NumberToText
{
    public static string NumberToWords(int number)
    {
        if (number == 0)
            return "zero";

        string words = "";

        if ((number / 100) > 0) // gets the hundrets
        {
            words += NumberToWords(number / 100) + " hundred ";
            number %= 100;
        }

        if (number > 0) // gets the tens and ones
        {
            if (words != "") // less than hundred
                words += "and "; // more than hunderd

            var ones = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tens = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 20)
                words += ones[number]; // put the ones (from 0 to 19)
            else
            {
                words += tens[number / 10]; // put the tens (more than 19)
                if ((number % 10) > 0)
                    words += "-" + ones[number % 10]; // put the ones (from 0 to 19)
            }
        }

        return words;
    }

    static void Main()
    {
        int num;

        Console.Write("Number: ");
        if (int.TryParse(Console.ReadLine(), out num)) // checks if the inputed symbols are integer
        {
            if (num >= 0 && num <= 999) // checks if the number is in the interval [0 - 999]
            {
                Console.WriteLine(NumberToWords(num)); // calls the method NumberToWords to turn thr number into text
            }
            else
            {
                Console.WriteLine("Invalid input!"); // error messageif the number is not in the interval [0 - 999]
            }
        }
        else
        {
            Console.WriteLine("Invalid input!"); // error messageif the inputed symbols are not integer
        }
        Console.ReadLine();
    }
}