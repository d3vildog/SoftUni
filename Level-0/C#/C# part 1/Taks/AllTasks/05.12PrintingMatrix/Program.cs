namespace _05._12PrintingMatrix
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main(string[] args)
        {
            ////Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix 
               
            // Declaring variables
            int n;
            
            //User input
            Console.WriteLine("N < 20");
            Console.Write("Enter number for N : ");
            
            n = int.Parse(Console.ReadLine());
            int column = (n * 2) - 1;
            int[,] matrix =new int[n, n];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = col + 1 + row;
                }
            }
            // Solution
            for (int row = 0; row < n ; row++)
            {
                for (int col = 0; col < n ; col++)
                {
                    Console.Write(matrix[row, col] + "    ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
