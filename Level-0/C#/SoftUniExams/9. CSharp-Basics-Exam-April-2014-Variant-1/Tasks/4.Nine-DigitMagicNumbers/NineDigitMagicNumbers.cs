using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        // User input and initializing variables
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool combinationFound = false;

        // Searching for combinations
        for (int number1 = 111; number1 <= 777; number1++)
        {
            // Making variables, initializing second 3 digits and third 3 digits
            int number2 = number1 + diff;
            int number3 = number2 + diff;

            // Checking if the 9 digits are in range 1-7, checking if their sum is equal to the inputted sum, checking if the 3rd number is not bigger than the allowed and printing if we have found any combination
            if(IsInRange(number1) && IsInRange(number2) && IsInRange(number3) &&
                (number3 <= 777) &&
                SumOfDigits(number1) + SumOfDigits(number2) + SumOfDigits(number3) == sum)
            {
                Console.WriteLine("{0}{1}{2}", number1, number2, number3);
                combinationFound = true;
            }
        }

        // Printing No if no combination has been found
        if (!combinationFound)
        {
            Console.WriteLine("No");
        }
    }

    // Creating method for calculating the sum of the given digits
    private static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }

        return sum;
    }

    // Creating method for checking every digit if is it in range of 1 to 7
    private static bool IsInRange(int number)
    {
        string digits = number.ToString();
        bool isInRange = true;

        foreach (var digit in digits)
        {
            if (digit < '1' || digit > '7')
            {
                isInRange = false;
                break;
            }
        }

        return isInRange;
    }
}
