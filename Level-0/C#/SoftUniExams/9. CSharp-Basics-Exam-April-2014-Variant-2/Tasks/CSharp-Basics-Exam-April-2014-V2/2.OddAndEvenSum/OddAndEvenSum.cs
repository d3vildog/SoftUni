using System;
using System.Linq;

class OddAndEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstNumber = new int[n * 2+ 1];
        int[] secondNumber = new int[n * 2+ 1];

        for (int i = 1; i <= n * 2; i++)
        {
            if (i % 2 == 0)
            {
                firstNumber[i] = int.Parse(Console.ReadLine()); 
            }
            else
            {
                secondNumber[i] = int.Parse(Console.ReadLine());
            }
        }

        if (firstNumber.Sum() == secondNumber.Sum()) 
        {
            Console.WriteLine("Yes, sum={0}", firstNumber.Sum());
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstNumber.Sum() - secondNumber.Sum()));
        }
    }
}