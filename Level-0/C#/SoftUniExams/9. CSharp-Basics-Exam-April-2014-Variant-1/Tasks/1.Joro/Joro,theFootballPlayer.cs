using System;

class JorotheFootballPlayer
{
    static void Main()
    {
        // User input and creating variables
        string year = Console.ReadLine();
        decimal numberOfHolidays = decimal.Parse(Console.ReadLine());
        decimal hometownWeekends = decimal.Parse(Console.ReadLine());
        decimal result;

        // Calculating how many times Joro played football this year;
        if (year == "t")
        {
            result = ((52 - (decimal)hometownWeekends) * ((decimal)2 / 3)) + ((decimal)numberOfHolidays / 2) + 3 + hometownWeekends;
        }
        else
        {
            result = ((52 - (decimal)hometownWeekends) * ((decimal)2 / 3)) + ((decimal)numberOfHolidays / 2) + hometownWeekends;
        }

        // Outputting the result
        Console.WriteLine(Math.Floor(result));
    }
}

