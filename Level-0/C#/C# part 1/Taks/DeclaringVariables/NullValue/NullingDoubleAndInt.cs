using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValue
{
    class NullingDoubleAndInt
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;

            Console.WriteLine("a = " + a + ";" + "\n" + "b = " + b + ";");

            Console.ReadLine();
        }
    }
}
