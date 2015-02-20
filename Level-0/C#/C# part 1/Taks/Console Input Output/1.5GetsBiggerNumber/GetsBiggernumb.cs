using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5GetsBiggerNumber
{
    class GetsBiggernumb
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Now you will have to add 2 numbers\n The program will output bigger one!");
            Console.Write("Enter number 1: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int maxValue = Math.Max(firstNumber, secondNumber);

            Console.WriteLine("The bigger number is: {0}", maxValue);

            Console.ReadLine();
        }
    }
}
