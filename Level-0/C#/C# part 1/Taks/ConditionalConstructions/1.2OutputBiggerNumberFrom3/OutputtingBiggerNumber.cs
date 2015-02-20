using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2OutputBiggerNumberFrom3
{
    class OutputtingBiggerNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three sequence numbers:");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int max;

            if (firstNumber > secondNumber)
            {
                max = firstNumber;
                if (firstNumber > thirdNumber)
                {
                    max = firstNumber;
                }
                else
                {
                    max = thirdNumber;
                }
            }
            else
            {
                max = secondNumber;
                if (secondNumber > thirdNumber)
                {
                    max = secondNumber;
                }
                else
                {
                    max = thirdNumber;
                }
            }

            Console.WriteLine("The bigger number from the 3 is: {0}", max);
            Console.ReadKey();
                
        }
    }
}
