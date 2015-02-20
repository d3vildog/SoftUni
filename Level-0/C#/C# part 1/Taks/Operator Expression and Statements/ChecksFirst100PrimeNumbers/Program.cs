using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChecksFirst100PrimeNumbers
{
    class Program
    {

        static void Main(string[] args)
        {
            bool me = true;

            while (me)
            {
                Console.Write("Enter number: ");
                uint number = uint.Parse(Console.ReadLine());
                uint count = 0;
                for (int i = 1; i <= 100; i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("The number is prime");
                }
                else
                {
                    Console.WriteLine("The number is not prime");
                }
                Console.ReadLine();
            }
        }
    }

} 
