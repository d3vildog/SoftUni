using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._02BooleanExpressionThatChecksThis
{
    class This
    {
        static void Main(string[] args)
        {
            //declaring variables
            int enterednNumber;
            while (true)
            {
                //input 
                Console.WriteLine("Enter number or write 0 to end the program!");
                enterednNumber = int.Parse(Console.ReadLine());
                bool check = enterednNumber % 5 == 0 && enterednNumber % 7 == 0;

                if (check)
                {
                    Console.WriteLine("The number {0} can be divided by 5 and 7!" , enterednNumber);
                }
                else if (enterednNumber == -1)
                {
                    break;
                }
                else if(!check)
                {
                    Console.WriteLine("The number {0} cant be divided by 5 and 7", enterednNumber);
                }
            }
            Console.ReadLine();
            
        }
    }
}
