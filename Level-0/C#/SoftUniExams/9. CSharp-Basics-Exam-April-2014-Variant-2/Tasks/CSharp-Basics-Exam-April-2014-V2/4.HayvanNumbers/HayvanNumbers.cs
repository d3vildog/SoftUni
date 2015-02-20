using System;

class HayvanNumbers
{
    static void Main()
    {
        // User input and declaring variables
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool combinationFound = false;

        // Searching for combination and printing if there is any
        for (int numb1 = 555; numb1 <= 999; numb1++)
        {
            int numb2 = numb1 + diff;
            int numb3 = numb2 + diff;

            if (IsInRange(numb1) && IsInRange(numb2) && IsInRange(numb3) && (numb3 <= 999) && SumOfDigits(numb1) + SumOfDigits(numb2) + SumOfDigits(numb3) == sum)
            {
                Console.WriteLine("{0}{1}{2}", numb1, numb2, numb3);         
                combinationFound = true;
            }
        }

        // Printing no cuz no combination has been found
        if (combinationFound == false)
        {
            Console.WriteLine("No");
        }

    }

    // Summing the three digits that we get
    private static int SumOfDigits(int numb)
    {
        int sum = 0;

        while (numb > 0)
        {
            sum += numb % 10;
            numb = numb / 10;
        }

        return sum;
    }

    // Checking is the numbers are in the allowed range
    private static bool IsInRange(int numb)
    {
        string digits = numb.ToString();
        bool isInRange = true;

        foreach (var digit in digits)
        {
            if (digit < '5' || digit > '9')
            {
                isInRange = false;
            }
        }

        return isInRange;
    }
}