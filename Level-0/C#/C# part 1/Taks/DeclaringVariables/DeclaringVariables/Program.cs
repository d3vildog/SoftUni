using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort a = 52130;
            sbyte b = -115;
            ulong c = 4825932;
            byte z = 97;
            int i = -10000;
            //declaring an integer 256 in hexdecimal format
            int numberInHex = 0xFE;
            Console.WriteLine(numberInHex);
            Console.WriteLine((char)0x72);
            Console.ReadLine();

            Boolean isFemale = false;

            switch (isFemale)
            {
                case true:
                    Console.WriteLine("Well Hello mileidy");
                    break;
                case false:
                    Console.WriteLine("Well hello milord");
                    break;
            }

            Console.ReadLine();
        }
    }
}
