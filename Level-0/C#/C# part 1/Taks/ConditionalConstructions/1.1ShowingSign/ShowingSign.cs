using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1ShowingSign
{
    class ShowingSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers; ");
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("\n\n");
            //checking firstnumber
            if (firstNumber > 0)
            {
                Console.WriteLine("+" + firstNumber);
            }
            else
            {
                Console.WriteLine(firstNumber);
            }
           
            //checking secondnumber
            if (secondNumber > 0)
            {
                Console.WriteLine("+" + secondNumber);
            }
            else
            {
                Console.WriteLine(secondNumber);
            }

            //checking thirdnumber
            if (thirdNumber > 0)
            {
                Console.WriteLine("+" + thirdNumber);
            }
            else
            {
                Console.WriteLine(thirdNumber);
            }
            Console.ReadKey();


        
        }
    }
}
