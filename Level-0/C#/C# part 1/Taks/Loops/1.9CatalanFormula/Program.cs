using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9CatalanFormula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N>=0\nEnter number for N: ");
            int n = int.Parse(Console.ReadLine());
            decimal catalan;
            int faktN = 1;
            int fakt1 = 1;
            int fakt2 = 1;
            int fakt3;
            if (n >= 0)
            {
                //calculating first part of the formula
                for (int i = 1; i <= n * 2; i++)
                {
                    fakt1 *= i;
                }
                //calculating second part of the formula
                for (int i = 1; i <= (n + 1); i++)
                {
                    fakt2 *= i;
                }
                for (int i = 1; i <= n; i++)
                {
                    faktN *= i;
                }
            }
            fakt3 = fakt2 * faktN;
            //catalan[n] = ((2n)!) / ((n + 1)!*n!);
            catalan = fakt1 / fakt3;
            Console.WriteLine("The answer of this formula is : " + catalan);
            Console.ReadKey();
        }
    }
}
