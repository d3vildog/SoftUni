using System;

class Program
{
    static void Main()
    {
        // User input 
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int firstNumber = 111; firstNumber <= 777; firstNumber++)
        {
            int secondNumber = firstNumber + diff;
            int thirdNumber = secondNumber+ diff;

            if (isValid(firstNumber) && isValid(secondNumber) && isValid(thirdNumber) &&
                (thirdNumber <= 777) &&
                SumOf(firstNumber) + SumOf(secondNumber) + SumOf(thirdNumber) == sum) 
            {
                isFound = true;
                Console.WriteLine("{0}{1}{2}", firstNumber, secondNumber, thirdNumber);
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }

    private static int SumOf(int numbers)
    {
        int sum = 0;

        while (numbers > 0)
	    {
            sum += numbers % 10;
            numbers /= 10;
	    }

        return sum;
    }

    private static bool isValid(int number)
    {
        bool isValid = true;
        string numb = number.ToString();

        foreach (var numbb in numb)
        {
            if (numbb < '1' || numbb > '7')
            {
                isValid = false;
            }
        }

        return isValid;
    }
}