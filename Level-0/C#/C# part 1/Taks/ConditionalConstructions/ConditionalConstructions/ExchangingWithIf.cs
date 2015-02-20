using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalConstructions
{
    class ExchangingWithIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            int biggerNumber = firstNumber;
            if (secondNumber > firstNumber)
            {
                biggerNumber = secondNumber;
            }

            Console.WriteLine("The bigger number is: {0}", biggerNumber);
            Console.ReadLine();
        }
    }
}
