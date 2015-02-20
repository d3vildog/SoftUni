using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jjjj
{
    class Program
    {
        static void Main(string[] args)
        {
            int n6=0;
            int n7=224;

            for (int bitPosition = 0; bitPosition < 8; bitPosition++)
            {
                if ((n7 >> bitPosition) == 0 && (n6 >> bitPosition) == 1)
                {
                    n7 |= (1 << bitPosition);
                    n6 ^= (1 << bitPosition);
                }
            }

            Console.WriteLine(n6);
            Console.WriteLine(n7);
            Console.ReadLine();

        }
    }
}
