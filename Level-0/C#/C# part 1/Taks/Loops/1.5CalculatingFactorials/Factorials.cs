using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._5CalculatingFactorials
{
    class Factorials
    {
        static void Main(string[] args)
        {

            decimal numberN;
            decimal numberK;
            decimal faktN = 1;
            decimal faktK = 1;

            Console.WriteLine("(1 < N < K)");
            Console.Write("Enter number for K: ");
            numberK = decimal.Parse(Console.ReadLine());
            Console.Write("Enter number for N: ");
            numberN = decimal.Parse(Console.ReadLine());
            
            if(numberN > 1 && numberK > numberN)
            {
                for (int i = 1; i <= numberK; i++)
                {
                    faktK *= i;
                }
                for (int i = 1; i <= numberN; i++)
                {
                    faktN *= i;
                }
            }
            else
            {
                Console.WriteLine("Invalid input!!!");
            }

            decimal numberKN = numberK - faktN;
            decimal faktKN = 1;
            for (int i = 1; i <= numberKN; i++)
            {
                faktKN *= i;
            }
            Console.WriteLine("Factorial of {0} is: {1}", numberK, faktK);
            Console.WriteLine("Factorial of {0} is: {1}", numberN , faktN );
            decimal result = (faktN * faktK) / faktKN;
            Console.WriteLine("The result of the equation is : " + result);
            Console.ReadKey();
        }
    }
}
