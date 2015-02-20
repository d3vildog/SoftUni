using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._8EnteringNAndOutPuting_1._.N_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("[1...N] Enter N:");
            int numbN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbN; i++)
            {
                if (i != numbN)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i + ".");
                }
            }

            Console.ReadLine(); 
        }
    }
}
