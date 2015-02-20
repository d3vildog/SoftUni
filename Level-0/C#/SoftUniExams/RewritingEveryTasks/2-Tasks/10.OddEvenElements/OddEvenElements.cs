using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddEvenElements
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        string[] numbers = Console.ReadLine().Split(' ');
        bool isOdd = true;

        // Odd
        decimal oddSum = 0;
        decimal oddMin = decimal.MaxValue;
        decimal oddMax = decimal.MinValue;

        // Even
        decimal evenSum = 0;
        decimal evenMin = decimal.MaxValue;
        decimal evenMax = decimal.MinValue;

        if (numbers.Length == "")
        {
            numbers = new string[0];
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (isOdd)
            {
                oddSum += decimal.Parse(numbers[i]);
                oddMin = Math.Min(oddMin, decimal.Parse(numbers[i]));
                oddMax = Math.Max(oddMax, decimal.Parse(numbers[i]));
            }
            else
            {
                evenSum += decimal.Parse(numbers[i]);
                evenMin = Math.Min(evenMin, decimal.Parse(numbers[i]));
                evenMax = Math.Max(evenMax, decimal.Parse(numbers[i]));
            }

            isOdd = !isOdd;
        }

        if (numbers.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (numbers.Length < 2)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", (double)oddSum, (double)oddMin, (double)oddMax);
        }
        else if (numbers.Length > 2)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", (double)oddSum, (double)oddMin, (double)oddMax, (double)evenSum, (double)evenMin, (double)evenMax);
        }
    }
}