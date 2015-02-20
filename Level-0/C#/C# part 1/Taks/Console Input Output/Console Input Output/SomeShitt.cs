using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace Console_Input_Output
{
    class SomeShitt
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg");
            string input = Console.ReadLine();
            input = input.Replace(",", ".");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine(d);
          //  Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Дани и Еви");
            Console.ReadLine();


        }
    }
}
