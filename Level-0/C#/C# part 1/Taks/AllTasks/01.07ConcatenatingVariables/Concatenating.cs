using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._07ConcatenatingVariables
{
    class Concatenating
    {
        static void Main(string[] args)
        {
            //Initializing
            string firstString = "Hello ";
            string secondString = "World!";

            //Concatenating 2 strins and then assign them to 3th string
            object concatenatingString = firstString + secondString;
            string result = (string)concatenatingString;

            //Output
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
