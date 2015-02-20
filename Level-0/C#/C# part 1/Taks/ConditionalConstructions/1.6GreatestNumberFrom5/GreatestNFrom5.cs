using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._6GreatestNumberFrom5
{
    class GreatestNFrom5
    {
        static void Main(string[] args)
        {
            int max = 0 ;
            Console.WriteLine("Enter 5 numbers..");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourNumber = int.Parse(Console.ReadLine());
            int fivetNumber = int.Parse(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                max = firstNumber;
                if(firstNumber > thirdNumber)
                {
                    max = firstNumber;
                    if (firstNumber > fourNumber)
                    {
                        max = firstNumber;
                        if (firstNumber > fivetNumber)
                        {
                            max = firstNumber;
                        }
                        else
                        {
                            max = fivetNumber;
                        }
                    }
                    else
                    {
                        max = fourNumber;
                    }
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
                    if (secondNumber > fourNumber)
                    {
                        max = secondNumber;
                        if (secondNumber > fivetNumber)
                        {
                            max = secondNumber;
                        }
                        else
                        {
                            max = fivetNumber;
                        }

                    }
                    else
                    {
                        max = fourNumber;
                    }
                }
                else
                {
                    max = thirdNumber;
                }

            }

            Console.WriteLine("The max number is: " + max);
            Console.ReadKey();

        }
    }
}
