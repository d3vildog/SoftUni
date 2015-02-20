using System;

class FitBoxIn
{
    static void Main()
    {
        // First box inputs
        int fW = int.Parse(Console.ReadLine());
        int fH = int.Parse(Console.ReadLine());
        int fD = int.Parse(Console.ReadLine());

        // Second box inputs
        int sW = int.Parse(Console.ReadLine());
        int sH = int.Parse(Console.ReadLine());
        int sD = int.Parse(Console.ReadLine());

        Check(fW, fH, fD, sW, sH, sD);
        Check(fW, fH, fD, sW, sD, sH);
        Check(fW, fH, fD, sH, sW, sD);
        Check(fW, fH, fD, sH, sD, sW);
        Check(fW, fH, fD, sD, sH, sW);
        Check(fW, fH, fD, sD, sW, sH);

        Check(sW, sH, sD, fW, fH, fD);
        Check(sW, sH, sD, fW, fD, fH);
        Check(sW, sH, sD, fH, fW, fD);
        Check(sW, sH, sD, fH, fD, fW);
        Check(sW, sH, sD, fD, fH, fW);
        Check(sW, sH, sD, fD, fW, fH);
    }

    private static void Check(int fW, int fH, int fD, int sW, int sH, int sD)
    {
        if (fW < sW && fH < sH && fD < sD)
        {
            Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", fW, fH, fD, sW, sH, sD);
        }
    }
}