using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._08MakingStringWithQuotation
{
    class Outputing2Strings
    {
        static void Main(string[] args)
        {

            //Initializing
            string withoutQuotation = "The use of quotation causes difficulties.";
            string withQuotation = "The \"use\" of quotation causes difficulties. ";

            //Outputting
            Console.WriteLine(withoutQuotation + "\n" + withQuotation);
            Console.ReadLine();
        }
    }
}
