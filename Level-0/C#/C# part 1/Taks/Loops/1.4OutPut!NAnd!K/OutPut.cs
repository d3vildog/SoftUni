using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._4OutPut_NAnd_K
{
    class OutPut
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(1<K<N)");
            Console.WriteLine("Enter K: ");
            decimal faktK = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter N: ");
            decimal faktN = decimal.Parse(Console.ReadLine());
            decimal faktorialResult = 1;
            if (faktK > 1 && faktK < faktN)
            {
                for (int i = 1; i <= faktK; i++)
                {
                    faktorialResult = faktorialResult * i;
                }
                Console.WriteLine(faktK + "!" + " = " + faktorialResult);
                faktorialResult = 1;

                for (int i = 1; i <= faktN; i++)
                {
                    faktorialResult *= i;
                }
                Console.WriteLine(faktN + "!" + " = " + faktorialResult);
            }
            else
            {
                Console.WriteLine("Incorrect Input!");
            }
            Console.ReadKey();
        }
    }
}
