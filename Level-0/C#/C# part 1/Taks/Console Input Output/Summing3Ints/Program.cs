using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summing3Ints
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine ());

            Console.WriteLine("The sum of {0}, {1} and {2} is: {3}", firstNumber, secondNumber, thirdNumber, firstNumber + secondNumber + thirdNumber);

            Console.ReadLine();
        }
    }
}
