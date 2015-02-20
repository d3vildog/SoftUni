using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carpets_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] matrix = new int[N, N];

            int startSlash = N / 2 - 1;
            int endSlash = N / 2 - 1;

            bool isSlash = true;
            for (int row = 0; row < N / 2; row++)
            {
                for (int col = 0; col < N / 2; col++)
                {
                    if (startSlash <= col && col <= endSlash)
                    {
                        if (isSlash)
                        {
                            matrix[row, col] = 2;
                            matrix[row, N - 1 - col] = 3;
                            matrix[N - 1 - row, col] = 3;
                            matrix[N - 1 - row, N - 1 - col] = 2;
                            isSlash = false;
                        }
                        else
                        {
                            matrix[row, col] = 1;
                            matrix[row, N - 1 - col] = 1;
                            matrix[N - 1 - row, col] = 1;
                            matrix[N - 1 - row, N - 1 - col] = 1;
                            isSlash = true;
                        }

                    }
                }
                isSlash = true;
                startSlash--;
            }
            //printing
            for (int row = 0; row < N; row++)
            {
                for (int cow = 0; cow < N; cow++)
                {
                    if (matrix[row, cow] == 0)
                    {
                        Console.Write(".");
                    }
                    else if (matrix[row, cow] == 1)
                    {
                        Console.Write(" ");
                    }
                    else if(matrix[row,cow] == 2)
                    {
                        Console.Write("/");
                    }
                    else if (matrix[row, cow] == 3)
                    {
                        Console.Write("\\");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
