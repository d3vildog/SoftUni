using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractingNumbFromBitNumb
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;
            int y = x ?? -1;

            int numbI = 3;
            int bitNumberB = 2;

            int mask = 1 << bitNumberB;
            int iAndMask = numbI & mask;
            int valieBit = iAndMask >> bitNumberB;

            Console.WriteLine(valieBit);
            Console.ReadLine();

            //Console.Write("Please enter number: ");
            //int number = int.Parse(Console.ReadLine());

            //Console.Write("Please enter bit position: ");
            //int position = int.Parse(Console.ReadLine());

            //int bitValue = (number >> position) & 1;

            //Console.WriteLine("The bit value at position {0} in the number {1} is -> {2}", position, number, bitValue);
        }
    }
}
