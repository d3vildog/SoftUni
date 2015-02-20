using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._7OutputingNnumbersOfFibonachi
{
    class nother
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number N : ");
            int numberN = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] fb = new int[numberN];
            fb[0] = 0;
            fb[1] = 1;
            Console.WriteLine(1 + " - " + fb[0]);
            Console.WriteLine(2 + " - " + fb[1]);
            for (int i = 2; i < numberN; i++)
            {
                fb[i] = fb[i-1] + fb[i-2];
                Console.WriteLine(i + " - " + fb[i]);
            }
            foreach (var summingFBN in fb)
	            {
		            sum += summingFBN;
	            }
            Console.WriteLine("The sum of this numbers is {0}", sum);
            Console.ReadLine();
        }
    }
}
