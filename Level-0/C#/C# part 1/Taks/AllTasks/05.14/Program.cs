namespace _05._14
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
           ////Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N numbers arranged as a spiral.

            int n;
            Console.Write("Input an integer number in the interval [1;19]: ");
            bool valid = Int32.TryParse(Console.ReadLine(), out n);
            if (valid && (n > 0 && n < 20))
            {
                int[,] num = new int[n, n];
                int x = 0, y = 0, direction = 0;
                for (int i = 0; i < n * n; i++)
                {
                    num[x, y] = i + 1;
                    switch (direction)
                    {
                        case 0:
                            if (x < n - 1 && num[x + 1, y] == 0)
                            {
                                x++;
                            }
                            else
                            {
                                direction = (++direction) % 4;
                                y++;
                            }
                            break;
                        case 1:
                            if (y < n - 1 && num[x, y + 1] == 0)
                            {
                                y++;
                            }
                            else
                            {
                                direction = (++direction) % 4;
                                x--;
                            }
                            break;
                        case 2:
                            if (x > 0 && num[x - 1, y] == 0)
                            {
                                x--;
                            }
                            else
                            {
                                direction = (++direction) % 4;
                                y--;
                            }
                            break;
                        case 3:
                            if (y > 0 && num[x, y - 1] == 0)
                            {
                                y--;
                            }
                            else
                            {
                                direction = (++direction) % 4;
                                x++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid direction value!");
                            break;
                    }
                }
                int align = ((n * n).ToString()).Length;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0}", ((num[j, i].ToString()).PadRight(align / 2)).PadLeft(align + 1));
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input data!");
            }

            Console.ReadKey();
        }
    }
}
