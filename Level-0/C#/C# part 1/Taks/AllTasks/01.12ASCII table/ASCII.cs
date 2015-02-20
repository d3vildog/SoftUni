using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._12ASCII_table
{
    class ASCII
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 255; i++)
            {
                Console.WriteLine("{0} = {1}", i , (char)i);
            }
            Console.ReadLine();

        }
    }
}
