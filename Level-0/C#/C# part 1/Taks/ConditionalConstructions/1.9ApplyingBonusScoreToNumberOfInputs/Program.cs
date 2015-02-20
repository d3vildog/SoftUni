using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9ApplyingBonusScoreToNumberOfInputs
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter an integer [1...9] ");
            int enteredNumber = int.Parse(Console.ReadLine());

            switch (enteredNumber)
            {
                case 1:
                case 2:
                case 3:
                    enteredNumber = enteredNumber * 10;
                    break;
                case 4:
                case 5:
                case 6:
                    enteredNumber = enteredNumber * 100;
                    break;
                case 7:
                case 8:
                case 9:
                    enteredNumber = enteredNumber * 1000;
                    break;
                default:
                    Console.WriteLine("Incorrect Input!!!");
                    break;
            }

            Console.WriteLine("The result of the action is: " + enteredNumber);
            Console.ReadLine();

        }
    }
}
