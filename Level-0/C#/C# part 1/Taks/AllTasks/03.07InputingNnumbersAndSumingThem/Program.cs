namespace _03._07InputingNnumbersAndSumingThem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   public class Program
    {
      public static void Main(string[] args)
        {
            //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

            int template;
            List<int> numbersN = new List<int>();
            bool more = true;

            while (more)
            {
                Console.Write("Enter number or enter 0 to close!");
                template = int.Parse(Console.ReadLine());
                numbersN.Add(template);
                if (template == 0)
                {
                    more = false;
                }
            }

            Console.WriteLine(numbersN.Sum()); ;

            //for (int i = 0; i < numbersN.Count; i++)
            //{
            //    Console.WriteLine(numbersN[i]);
            //}

            Console.ReadKey();
        }
    }
}
