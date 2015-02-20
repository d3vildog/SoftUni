using System;
using System.Numerics;

class Tribonacii
{
    static void Main()
    {
        BigInteger t1 = BigInteger.Parse(Console.ReadLine());
        BigInteger t2 = BigInteger.Parse(Console.ReadLine());
        BigInteger t3 = BigInteger.Parse(Console.ReadLine());
        BigInteger N = BigInteger.Parse(Console.ReadLine());

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
        else
        {
            for (int i = 4; i <= N; i++)
            {
                BigInteger tribNew = t1 + t2 + t3;
                t1 = t2;
                t2 = t3;
                t3 = tribNew;
            }
            Console.WriteLine(t3);
        }
    }
}