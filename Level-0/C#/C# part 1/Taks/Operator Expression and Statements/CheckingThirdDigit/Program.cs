using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number:");
            int number = int.Parse(Console.ReadLine());
            if ((number / 100) % 10 == 7)
            {
                Console.WriteLine("Seven");
            }
            else
            {
                Console.WriteLine("Not seven");
            }
            Console.ReadLine();
        }
    }
}
