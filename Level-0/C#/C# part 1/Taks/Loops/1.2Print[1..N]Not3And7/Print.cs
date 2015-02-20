using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2Print_1._.N_Not3And7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number:  ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % i != 7)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.ReadKey();

        }
    }
}
