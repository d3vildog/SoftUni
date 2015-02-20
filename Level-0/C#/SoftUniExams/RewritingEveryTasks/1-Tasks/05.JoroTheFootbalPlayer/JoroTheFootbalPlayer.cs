using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string leapOrNot = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int hometowns = int.Parse(Console.ReadLine());
        int normalWeekends = 52;
        decimal playedFootbal;

        if (leapOrNot == "t")
        {
            playedFootbal = Math.Floor(((normalWeekends - hometowns) * ((decimal)2 / 3)) + hometowns + (holidays * 0.5m) + 3);
        }
        else
        {
            playedFootbal = Math.Floor(((normalWeekends - hometowns) * ((decimal)2 / 3)) + hometowns + (holidays * 0.5m));
        }

        Console.WriteLine(playedFootbal);
    }
}