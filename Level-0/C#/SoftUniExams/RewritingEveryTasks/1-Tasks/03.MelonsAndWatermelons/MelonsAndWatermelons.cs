using System;

class MelonsAndWatermelons
{
    static void Main()
    {
        // User input
        int startingDay = int.Parse(Console.ReadLine());
        int sequentialDays = int.Parse(Console.ReadLine());
        int melons = 0;
        int watermelons = 0;

        // Counting melons and watermelons
        for (int day = startingDay; day < sequentialDays + startingDay; day++)
        {
            switch (day % 7)
            {
                case 1:
                    watermelons += 1;
                    break;
                case 2:
                    melons += 2;
                    break;
                case 3:
                    watermelons += 1;
                    melons += 1;
                    break;
                case 4:
                    watermelons += 2;
                    break;
                case 5:
                    watermelons += 2;
                    melons += 2;
                    break;
                case 6:
                    watermelons += 1;
                    melons += 2;
                    break;
                case 7:
                    break;
                default:
                    break;
            }
        }

        // Outputting the result
        Quantity(watermelons, melons);
    }

    private static void Quantity(int watermelons, int melons)
    {
        if (watermelons > melons)
        {
            Console.WriteLine("{0} more watermelons", watermelons - melons);
        }
        else if (watermelons < melons)
        {
            Console.WriteLine("{0} more melons", melons - watermelons);
        }
        else if (watermelons == melons)
        {
            Console.WriteLine("Equal amount: {0}", watermelons);
        }
    }
}