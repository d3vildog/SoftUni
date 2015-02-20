using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPutEnteredMinNumber
{
    class MinAndMax
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sequence of numbers: ");
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The max number is: {0}\nThe min number is: {1}", numbers.Max(), numbers.Min());
            Console.ReadKey();
        }
    }
}
