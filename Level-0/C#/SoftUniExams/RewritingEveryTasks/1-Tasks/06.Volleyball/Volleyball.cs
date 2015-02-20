using System;

class Volleyball
{
    static void Main()
    {
        // User input
        string LeapOrNot = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometowns = int.Parse(Console.ReadLine());

        // Solution
        decimal result = 0;
        int normalWeekends = 48;
        if (LeapOrNot == "leap")
        {
            result = Math.Floor((((normalWeekends - hometowns) * 3/4m) + hometowns + (holidays * (2/3m))) * 1.15m);
        }
        else
        {
            result = Math.Floor(((normalWeekends - hometowns) * 3/4m) + hometowns + (holidays * (2/3m)));
        }

        Console.WriteLine(result);
    }
}