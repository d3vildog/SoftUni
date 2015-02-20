using System;
using System.Linq;

class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int firstSum = 0;
        int secondSum = 0;

        for (int i = 1; i <= n * 2; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (i <= n)
            {
                firstSum += number;
            }else
            {
                secondSum += number;
            }
        }

        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum=" + firstSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstSum - secondSum));
        }
    }
}