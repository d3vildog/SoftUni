using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._11ExchangingAandB
{
    class Exchanging
    {
        static void Main(string[] args)
        {
            //Input!!!
            Console.Write("Enter A: ");
            int numberA = int.Parse(Console.ReadLine());

            Console.Write("Enter B: ");
            int numberB = int.Parse(Console.ReadLine());

            //declaring variable for temporary keeping value of A
            int temporaryVaiable;
            temporaryVaiable = numberA;
            numberA = numberB;
            numberB = temporaryVaiable;

            //Output
            Console.WriteLine("Number A: {0}\nNumber B: {1}", numberA, numberB);

            Console.ReadLine();

        }
    }
}
