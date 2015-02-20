using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._9FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            //decimal firstNumber = 0;
            //decimal secondNumber = 1;
            //decimal sum = 0;
            //Console.WriteLine(firstNumber);
            //Console.WriteLine(secondNumber);
            //for (int i = 1; i < 100; i++)
            //{
            //    sum = firstNumber + secondNumber;
            //    firstNumber = secondNumber;
            //    secondNumber = sum;
            //    Console.WriteLine(sum);
            //}
            Console.WriteLine("Outputting Fibonacci first 100 members of the sequence: ");

            ulong[] fb = new ulong[100];
            fb[0] = 0;
            fb[1] = 1;
            Console.WriteLine(0 + " - " + fb[0]);
            Console.WriteLine(1 + " - " + fb[1]);
            for (int n = 2; n < 100; n++)
            {
                fb[n] = fb[n - 1] + fb[n - 2];
                Console.WriteLine(n + " - " + fb[n]);
            }

            Console.ReadLine();
        }
    }
}
