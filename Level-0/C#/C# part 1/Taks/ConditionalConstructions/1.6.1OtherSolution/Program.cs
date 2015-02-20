using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6._1OtherSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] numbers = new int[5];
                for (int count = 0; count < 5; count++)
                {
                    Console.Write("Enter number: ");
                    int n = int.Parse(Console.ReadLine());
                    numbers[count] = n;
                }
                Console.WriteLine("Biggest number is: {0}", numbers.Max());
                Console.ReadKey();
            }
        }
    }
}
