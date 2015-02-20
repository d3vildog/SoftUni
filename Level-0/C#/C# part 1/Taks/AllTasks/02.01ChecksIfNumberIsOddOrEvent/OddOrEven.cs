using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._01ChecksIfNumberIsOddOrEvent
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("Enter number: ");
            int theNumber = int.Parse(Console.ReadLine());

            //Checks if its Odd or Even
            if (theNumber % 2 == 0)
            {
                Console.WriteLine(theNumber + " is Even");
            }
            else if (theNumber % 2 != 0)
            {
                Console.WriteLine(theNumber + " is Odd");
            }
            else
            {
                Console.WriteLine("Incorrect input!!!");
            }

            Console.ReadLine();
        }
    }
}
