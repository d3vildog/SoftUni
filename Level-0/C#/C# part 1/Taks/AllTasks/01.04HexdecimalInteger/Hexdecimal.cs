using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization; //This must be imported for NumberStles!!!

namespace _01._04HexdecimalInteger
{
    class Hexdecimal
    {
        static void Main(string[] args)
        {
            //initialize
            int test = 254;

            //write number in hex format
            Console.WriteLine("{0:x8}" , test);

            //convert to hex
            string hex = test.ToString("X8");

            //convert from hex to integer
            int test2 = int.Parse(hex, NumberStyles.AllowHexSpecifier);
            Console.WriteLine(test == test2);

            //pause after the program execute
            Console.ReadLine();
        }
    }
}
