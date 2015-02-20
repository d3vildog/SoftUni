using System;

class PeaceOfCake
{
    static void Main()
    {
        decimal numberA = int.Parse(Console.ReadLine());
        decimal numberB = int.Parse(Console.ReadLine());
        decimal numberC = int.Parse(Console.ReadLine());
        decimal numberD = int.Parse(Console.ReadLine());

        if ((numberA / numberB) + (numberC / numberD) >= 1)
        {
            Console.WriteLine(Math.Floor((numberA / numberB) + (numberC / numberD)));
        }
        else
        {
            Console.WriteLine("{0:F22}", (numberA / numberB) + (numberC / numberD));
        }

        decimal numerator = (numberD * numberA) + (numberC * numberB);
        decimal denominator = numberB * numberD;
        Console.WriteLine("{0}/{1}", numerator, denominator);
    }
}