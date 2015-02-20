using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddOrEven
{
    class OddOrEvent
    {
        static void Main(string[] args)
        {
            string restart = "y";
            while (restart == "y")
            {
                Console.WriteLine("Enter number to check if its odd or even: ");
                int oddOrEven = int.Parse(Console.ReadLine());
                int remeinder = oddOrEven % 2;
                string result = ((remeinder == 0) ? "Even" : "Odd");
                Console.WriteLine(result + "\n");
                Console.WriteLine("Do you want to check new number?(y or n)");
                restart = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
