namespace Ihopeilearn_it
{
    using System;
    using System.Diagnostics;
    using System.Linq;

   public class Program
    {
       public static void Main(string[] args)
        {
           // Input
           Console.Write("Enter the number: ");
           uint number = uint.Parse(Console.ReadLine());
           Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
           Console.Write("Enter first starting bit: ");
           byte firstBitToSwap = byte.Parse(Console.ReadLine());
           Console.Write("Enter second starting bit: ");
           byte secondBitToSwap = byte.Parse(Console.ReadLine());
           Console.Write("Enter how many bits you want to swap: ");
           byte bitToSwap = byte.Parse(Console.ReadLine());

           Stopwatch executionTime = new Stopwatch();
           executionTime.Start();

           uint bitMask = (uint)(Math.Pow(2, bitToSwap) - 1);

           uint result = (~(bitMask << secondBitToSwap) & ~(bitMask << firstBitToSwap) & number)
                            | (((number & (bitMask << secondBitToSwap)) >> (secondBitToSwap - firstBitToSwap)) |
                            ((number & (bitMask << firstBitToSwap)) << (secondBitToSwap - firstBitToSwap)));

           Console.WriteLine(result);
           Console.WriteLine(76543210);
           Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '8'));
           Console.WriteLine(Convert.ToString(result, 2).PadLeft(8, '0'));
        
           executionTime.Stop();
           Console.WriteLine("Execution time: {0}", executionTime.Elapsed);
           Console.ReadLine();
       }
    }
}
