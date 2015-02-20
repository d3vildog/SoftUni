using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7SummingFewNumbers
{
    class SummingFewNumbbers
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
            Console.WriteLine("Enter -1 to see the result!");
            while(number != -1)
            {
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());
                if (number == -1)
                {
                    Console.WriteLine("Summing ...");
                }
                else
                {
                    sum += number;
                }
            }

            Console.WriteLine("The sum of this numbers is: " + sum);
            Console.ReadLine();

        }
    }
}
