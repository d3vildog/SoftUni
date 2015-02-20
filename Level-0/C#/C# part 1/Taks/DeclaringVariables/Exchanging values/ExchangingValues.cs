using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchanging_values
{
    class ExchangingValues
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            int timeVar;

            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);

            timeVar = a;
            a = b;
            b = timeVar;
            Console.WriteLine();

            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);

            Console.ReadLine();
        }
    }
}
