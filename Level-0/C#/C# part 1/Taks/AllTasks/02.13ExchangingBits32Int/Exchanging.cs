namespace _02._13ExchangingBits32Int
{
    using System;
    using System.Diagnostics;
    using System.Linq;

   public class Exchanging
    {
       public static void Main()
       {
           uint leavingOldNumbers;
           uint changingFirstBits;
           uint changingSecondBits;

            // Input
            Console.Write("Enter the number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Enter first starting bit: ");
            byte firstBitToSwap = byte.Parse(Console.ReadLine());
            Console.Write("Enter second starting bit: ");
            byte secondBitToSwap = byte.Parse(Console.ReadLine());
            Console.Write("Enter how many bits you want to swap: ");
            byte bitToSwap = byte.Parse(Console.ReadLine());
            
            Stopwatch executionTime = new Stopwatch();
            executionTime.Start();

            uint bitMask = (uint)(Math.Pow(2, bitToSwap) - 1);

            leavingOldNumbers = (~(bitMask << secondBitToSwap) & ~(bitMask << firstBitToSwap) & number);
            changingFirstBits = ((number & (bitMask << secondBitToSwap)) >> (secondBitToSwap - firstBitToSwap));
            changingSecondBits = ((number & (bitMask << firstBitToSwap)) << (secondBitToSwap - firstBitToSwap));

            //uint result = (~(bitMask << secondBitToSwap) & ~(bitMask << firstBitToSwap) & number)
              //               | (((number & (bitMask << secondBitToSwap)) >> (secondBitToSwap - firstBitToSwap)) |
              //               ((number & (bitMask << firstBitToSwap)) << (secondBitToSwap - firstBitToSwap)));
            Console.WriteLine();
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            Console.WriteLine();
            uint result = leavingOldNumbers | changingFirstBits | changingSecondBits;
            Console.WriteLine(Convert.ToString(~(bitMask << secondBitToSwap), 2));
            Console.WriteLine(Convert.ToString(~(bitMask << firstBitToSwap), 2));
            Console.WriteLine(Convert.ToString(2, 2).PadLeft(32, '0'));
            Console.WriteLine();
            Console.WriteLine(Convert.ToString((number & (bitMask << secondBitToSwap)), 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString((secondBitToSwap - firstBitToSwap), 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(((number & (bitMask << secondBitToSwap)) >> (secondBitToSwap - firstBitToSwap)), 2).PadLeft(32, '0'));
            Console.WriteLine();
            Console.WriteLine(Convert.ToString(((number & (bitMask << firstBitToSwap))), 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString((secondBitToSwap - firstBitToSwap), 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(((number & (bitMask << firstBitToSwap)) << (secondBitToSwap - firstBitToSwap)), 2).PadLeft(32, '0'));
            Console.WriteLine();
            Console.WriteLine(Convert.ToString(leavingOldNumbers | changingFirstBits | changingSecondBits, 2).PadLeft(32, '0') + " The New Number");
            Console.WriteLine();
            Console.WriteLine(Convert.ToString(leavingOldNumbers, 2).PadLeft(32, '0') + " leavingOldNumbers");
            Console.WriteLine(Convert.ToString(changingFirstBits, 2).PadLeft(32, '0') + " changingFirstBits");
            Console.WriteLine(Convert.ToString(changingSecondBits, 2).PadLeft(32, '0') + " changingSecondBits");
            Console.WriteLine("                                                                                                        76543210" + " counting");
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0') + " number");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0') + " result " + result);

            Console.WriteLine();
            executionTime.Stop();
            Console.WriteLine("Execution time: {0}", executionTime.Elapsed);
            Console.ReadLine();
        }
    }
}
