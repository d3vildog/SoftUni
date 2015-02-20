using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09CircleAndRectanglePoints
{
    class Checks
    {
        static void Main(string[] args)
        {
            int xPoint = 0; //point 
            int yPoint = 2;

            int xK = 1; //circle K((1,1),3)
            int yK = 1;
            int rK = 3;

            int rLeft = -1; //R(top=1, left=-1, width=6, height=2)
            int rTop = 1;
            int rWidth = 6;
            int rHeight = 2;

            bool inCircle = (Math.Pow(xPoint - xK, 2) + Math.Pow(yPoint - yK, 2) < Math.Pow(rK, 2));
            bool outRect =
                ((xPoint < rLeft) || (xPoint > rLeft + rWidth)
                || (yPoint > rTop) || (yPoint < rTop - rHeight));

            Console.WriteLine("Point is (In Circle & Out of Rectangle): " + (inCircle && outRect));

            Console.ReadLine();

        }
    }
}
