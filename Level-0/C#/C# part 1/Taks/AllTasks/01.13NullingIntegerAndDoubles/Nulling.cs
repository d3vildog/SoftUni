using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._13NullingIntegerAndDoubles
{
    class Nulling
    {
        static void Main(string[] args)
        {

            int? bucky = null;
            double? apple = null;
            double? how = bucky ?? -1;

            Console.WriteLine(how);
            Console.ReadLine();
        }
    }
}
