using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ExchangingBits
{
    class ExchangingBits
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number: ");
            uint number = UInt32.Parse(Console.ReadLine());
            Console.Write("Enter starting bit position (p, p < q) for first bit set: ");
            byte firstSwapBit = Byte.Parse(Console.ReadLine());
            Console.Write("Enter starting bit position (q) for second bit set: ");
            byte secondSwapBit = Byte.Parse(Console.ReadLine());
            Console.Write("Enter number of bits to swap: ");
            byte bitsToSwap = Byte.Parse(Console.ReadLine());

            Stopwatch executionTime = new Stopwatch();
            executionTime.Start();

            uint bitsMask = (uint)(Math.Pow(2, bitsToSwap) - 1);

            Console.WriteLine(((~(bitsMask << secondSwapBit) & ~(bitsMask << firstSwapBit)) & number) | (((number & (bitsMask << secondSwapBit)) >> (secondSwapBit - firstSwapBit)) | ((number & (bitsMask << firstSwapBit)) << (secondSwapBit - firstSwapBit))));

            executionTime.Stop();
            Console.WriteLine("Execution time: {0}", executionTime.Elapsed);
            Console.ReadLine();

        }
    }
}
