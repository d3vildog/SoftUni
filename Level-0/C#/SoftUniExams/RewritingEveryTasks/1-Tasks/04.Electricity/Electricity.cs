using System;

class Electricity
{
    static void Main()
    {
        int floors = int.Parse(Console.ReadLine());
        int flats = int.Parse(Console.ReadLine());
        DateTime exactTime = DateTime.Parse(Console.ReadLine());

        decimal sumOfWats = 0;
        if (exactTime.Hour >= 14 && exactTime.Hour <= 18)
        {
            sumOfWats = (int)(((100.53m * 2) + (2 * 125.90m)) * flats * floors);
        }
        else if (exactTime.Hour >= 19 && exactTime.Hour <= 23)
        {
            sumOfWats = (int)(((100.53m * 7) + (6 * 125.90m)) * flats * floors);
        }
        else if (exactTime.Hour >= 00 && exactTime.Hour <= 8)
        {
            sumOfWats = (int)(((100.53m * 1) + (8 * 125.90m)) * flats * floors);
        }

        Console.WriteLine("{0} Watts", sumOfWats);
    }
}