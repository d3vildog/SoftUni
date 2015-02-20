using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number for N(N<20): ");
            int thenumbN = int.Parse(Console.ReadLine());

            for (int row = 1; row <= thenumbN; row++)
            {
                int number = row;
                for (int column = 1; column <= thenumbN; column++)
                {
                    Console.Write(number + "");
                    number++;
                }
                Console.WriteLine();
                
            }

            Console.ReadKey();
        }
    }
}
/* 
    +---------+
    |_|_|_|_|_|
    | | | | | | 
    +---------+
*/