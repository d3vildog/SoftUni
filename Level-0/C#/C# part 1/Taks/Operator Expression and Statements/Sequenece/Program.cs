using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequenece
{
    class Sequence

    {
        static void Main(string[] args)
        {
            //int mask, p, n;
            //// Set the bit at position p to 0 in a number n
            //p = 5;
            //n = 35;                     // 00000000 00100011
            //mask = ~(1 << p);           // 11111111 11011111
            //int result = n & mask;      // 00000000 00000011
            //Console.WriteLine(result);  // 3
            //Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
            //Console.ReadLine();

            //Entering the Number N
            Console.Write("Enter integer: ");
            int theNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(theNumber, 2));

            //Entering the value for the bit valueV
            Console.Write("Enter value for this bit(1 or 0): ");
            int bitValue = int.Parse(Console.ReadLine());

            //Entering the position for the bit valueV
            Console.Write("Enter the possition for the value of the Bit: ");
            int possOfBit = int.Parse(Console.ReadLine());
            int mask;   //~(bitValue << possOfBit);
                        //bitValue << possOfBit;
            int nWithZeroMask;  //theNumberN & maskWithZero;
            int nWithOneMask;   //theNumberN | maskWithOne;
            if (bitValue == 1)
            {
                mask = bitValue << possOfBit;
                nWithOneMask = theNumber | mask;
                Console.WriteLine("The binary representation of the number is {0}({1}).", nWithOneMask, Convert.ToString(nWithOneMask, 2).PadLeft(5, '0'));
            }
            else if(bitValue == 0)
            {

                mask = ~(bitValue+1 << possOfBit);
                nWithZeroMask = theNumber & mask;
                Console.WriteLine("The binary representation of the number is {0}({1}).", nWithZeroMask, Convert.ToString(nWithZeroMask, 2).PadLeft(5, '0'));
            }

            //int? checkTheValue = null;
            Console.ReadLine();

        }
    }
}
