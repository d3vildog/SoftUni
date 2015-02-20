using System;

class HayvanNumbers
{
    static void Main()
    {
        // User input and variables
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int firstNumber = 555; firstNumber <= 999; firstNumber++)
        {
            int secondNumber = firstNumber + diff;
            int thirdNumber = secondNumber + diff;

            if (isValid("" + firstNumber + secondNumber + thirdNumber) &&
                (thirdNumber <= 999) &&
                SumOf(firstNumber) + SumOf(secondNumber) + SumOf(thirdNumber) == sum)
            {
                isFound = true;
                Console.WriteLine("" + firstNumber + secondNumber + thirdNumber);
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }

    private static int SumOf(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }

    private static bool isValid(string str)
    {
        bool valid = true;

        foreach (var item in str)
        {
            if (item < '5' || item > '9')
            {
                valid = false;
            }
        }

        return valid;
    }
}