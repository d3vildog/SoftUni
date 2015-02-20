using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AddEvenSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int oddSum = 0;
        int evenSum = 0;
        bool isOdd = true;

        for (int i = 0; i < n * 2; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (isOdd)
            {
                oddSum += number;
            }
            else
            {
                evenSum += number;
            }
            isOdd = !isOdd;
        }

        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, sum=" + oddSum);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(oddSum - evenSum));
        }
    }
}