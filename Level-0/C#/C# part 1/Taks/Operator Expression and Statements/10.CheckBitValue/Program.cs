using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CheckBitValue
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1100
            int bitAtP = 3;
            int numberV = 12;
            Console.WriteLine(Convert.ToString(numberV, 2));

            int mask = 1 << bitAtP;                          // 0000 1000
            Console.WriteLine(Convert.ToString(mask, 2));
            int nAndMask = numberV & mask;                   // 0000 1100
            Console.WriteLine(Convert.ToString(nAndMask, 2)); // 0000 1000   // 0000 1000
            int bit = nAndMask >> bitAtP;
            Console.WriteLine(Convert.ToString(bit, 2));
            Console.WriteLine((bit == 1) ? "true" : "false");

            Console.ReadLine();
        }
    }
}
