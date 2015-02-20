using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4DigitSwitchStatement
{
    class Switch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number ...");
            int enteredNumber = int.Parse(Console.ReadLine());

            switch (enteredNumber)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
            }
            Console.ReadKey();


        }
    }
}
