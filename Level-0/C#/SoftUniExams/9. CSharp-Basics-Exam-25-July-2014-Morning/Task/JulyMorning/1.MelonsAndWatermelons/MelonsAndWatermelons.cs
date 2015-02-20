using System;

class MelonsAndWatermelons
{
    static void Main()
    {
        int startingDay = int.Parse(Console.ReadLine());
        int consecutiveDays = int.Parse(Console.ReadLine());
        int melons = 0;
        int watermelons = 0;

        for (int dayOfWeek = startingDay; dayOfWeek < startingDay + consecutiveDays; dayOfWeek++)
        {
            switch (dayOfWeek % 7)
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
                default:
                    break;
            }
        }

        if (watermelons > melons)
        {
            Console.WriteLine("{0} more watermelons", watermelons - melons);
        }
        else if (melons > watermelons)
        {
            Console.WriteLine("{0} more melons", melons - watermelons);
        }
        else if(watermelons == melons)
        {
            Console.WriteLine("Equal amount: {0}", watermelons);
        }
    }
}