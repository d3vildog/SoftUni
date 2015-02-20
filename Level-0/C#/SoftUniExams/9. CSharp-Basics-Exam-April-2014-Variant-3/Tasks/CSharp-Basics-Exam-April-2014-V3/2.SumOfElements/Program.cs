using System;
using System.Linq;

class SumOfElements
{
    static void Main()
    {
        // User input 
        string userInput = Console.ReadLine();
        string[] numbers = userInput.Split(' ');
        long sum = 0;
        long max = long.MinValue;

        for (int i = 0; i < numbers.Length; i++)
        {
            long elemnt = long.Parse(numbers[i]);
            sum = sum + elemnt;

            if(max < elemnt)
            {
                max = elemnt;
            }
        }

        if (sum == max * 2)
        {
            Console.WriteLine("Yes, sum=" + (sum - max));
        }
        else
        {
            Console.WriteLine("No, diff=" + Math.Abs(sum - 2 * max));
        }
    }
}