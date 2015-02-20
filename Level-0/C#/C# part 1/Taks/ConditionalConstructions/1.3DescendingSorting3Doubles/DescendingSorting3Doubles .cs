using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3DescendingSorting3Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter three real numbers: ");
                double firstNumber = double.Parse(Console.ReadLine());
                double secondNumber = double.Parse(Console.ReadLine());
                double thirdNumber = double.Parse(Console.ReadLine());

                double maxValue;
                double midValue;
                double minValue;
                if (firstNumber > secondNumber)
                {
                    maxValue = firstNumber;
                    if (firstNumber > thirdNumber)
                    {
                        maxValue = firstNumber;
                        midValue = Math.Max(secondNumber, thirdNumber);
                        minValue = Math.Min(secondNumber, thirdNumber);
                    }
                    else
                    {
                        maxValue = thirdNumber;
                        midValue = Math.Max(firstNumber, secondNumber);
                        minValue = Math.Min(firstNumber, secondNumber);
                    }
                }
                else
                {
                    maxValue = secondNumber;
                    if (secondNumber > thirdNumber)
                    {
                        maxValue = secondNumber;
                        midValue = Math.Max(firstNumber, thirdNumber);
                        minValue = Math.Min(firstNumber, thirdNumber);
                    }
                    else
                    {
                        maxValue = thirdNumber;
                        midValue = Math.Max(firstNumber, secondNumber);
                        minValue = Math.Min(firstNumber, secondNumber);
                    }
                }

                Console.WriteLine("The max value is: " + maxValue);
                Console.WriteLine("The mid value is: " + midValue);
                Console.WriteLine("The min value is: " + minValue);
                Console.WriteLine();
                Console.WriteLine(minValue + ", " + midValue + ", " + maxValue);
                Console.WriteLine("\n Restarting the program...");
                Console.ReadKey();
            }
        }
    }
}