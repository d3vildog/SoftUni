using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Print
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i != number)
                {
                Console.Write(i + ", ");
                }
                else
                {
                    Console.WriteLine(i + "!" );
                }
            }

            Console.ReadKey();

        }
    }
}
