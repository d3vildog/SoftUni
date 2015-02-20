using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividingInt5And7
{
    class DividingInt7n5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            bool divby5 = (number % 5) == 0;
            bool divby7 = (number % 7) == 0;
            
            if(divby5 && divby7){
                Console.WriteLine("You can divide " + number + " by 5 and 7!");
            }
            else
            {
                Console.WriteLine("You cant divide " + number + " by 5 and 7!");
            }
            Console.ReadLine();

        }
    }
}
