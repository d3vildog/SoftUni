using System;
using System.Linq;

class OddEvenElements
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;

        bool isOdd = true;
        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;
        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;
        string userInput = Console.ReadLine();
        string[] numbers = userInput.Split(' ');

        if (userInput == "")
        {
            // Known issue: split on empty string returns 1 token ""
            numbers = new string[0];
        }

        foreach (var number in numbers)
        {
            if (isOdd)
            {
                oddSum += decimal.Parse(number);
                if (decimal.Parse(number) < oddMin)
                {
                    oddMin = decimal.Parse(number);
                }
                if (decimal.Parse(number) > oddMax)
                {
                    oddMax = decimal.Parse(number);
                }
            }
            else
            {
                evenSum += decimal.Parse(number);
                if (decimal.Parse(number) < evenMin)
                {
                    evenMin = decimal.Parse(number);
                }
                if (decimal.Parse(number) > evenMax)
                {
                    evenMax = decimal.Parse(number);
                }
            }
            isOdd = !isOdd;
        }

        if (numbers.Length == 0)
        {
             Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (numbers.Length == 1)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)oddSum, (double)oddMin, (double)oddMax);
        }
        else
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
    }
}