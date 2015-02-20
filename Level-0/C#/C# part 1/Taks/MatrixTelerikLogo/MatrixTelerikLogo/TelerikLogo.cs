using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTelerikLogo
{
    class TelerikLogo
    {
        static void Main(string[] args)
        {
            //initializating
            int x = int.Parse(Console.ReadLine());
            int y = x;
            int z = (x / 2) + 1;

            int width = (2 * x + 2 * z) - 3;
            int height = width;

            int[,] matrix = new int[width, width];
            
            //solution - filling with ones

            int currentRow = x / 2;
            int currentCol = 0;

            while (true)
            {
                matrix[currentRow, currentCol] = 1;

                currentRow--;
                currentCol++;

                if(currentRow < 0)
                {
                    break;
                }
            }


            //printing
            for (int row = 0; row < width; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write('.');
                    }
                    else if (matrix[row, width] == 1)
                    {
                        Console.Write('*');
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
