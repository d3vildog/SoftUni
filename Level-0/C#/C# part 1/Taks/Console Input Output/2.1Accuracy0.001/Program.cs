using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1Accuracy0._001
{
    class Program
    {
        static void Main(string[] args)
        {
            //Неква супер тъпа задача нищо се не разбира!!!
            double sum = 1d;

            for (int i = 2; i <= 999; i++)
            {

                sum = sum + 1d / (i * ((i & 1) != 0 ? -1 : 1));

            }
            Console.WriteLine("{0:0.000}", sum);
            Console.ReadLine();
        }
    }
}
