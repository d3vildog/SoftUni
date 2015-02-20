using System;
using System.Numerics;

class Tribonacci
{
    static void Main()
    {
        // User input
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        BigInteger N = BigInteger.Parse(Console.ReadLine());

        // Solution
        if (N == 1)
        {
            Console.WriteLine(t1);
        }
        else if (N == 2)
        {
            Console.WriteLine(t2);
        }
        else if (N == 3)
        {
            Console.WriteLine(t3);
        }
        else if (N > 3)
        {
            BigInteger tn = 0;
            for (int i = 4; i <= N; i++)
            {
                tn = t1 + t2 + t3;

                t1 = t2;
                t2 = t3;
                t3 = tn;
            }
            Console.WriteLine(tn);
        }
    }
}