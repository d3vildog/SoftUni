using System;
using System.Linq;

class Volleyball
{
    static void Main()
    {
        // User input and declaring variables
        string year = Console.ReadLine();
        decimal holidays = decimal.Parse(Console.ReadLine());
        decimal hometownWeekends = decimal.Parse(Console.ReadLine());
        decimal result = 0;

        // Checking if the year is leap or normal and calculating the result
        if(year == "leap")
        {
            result = (((48 - (decimal)hometownWeekends) * 3 / 4) + hometownWeekends + (holidays * 2 / 3)) * 15 / 100 + (((48 - (decimal)hometownWeekends) * 3 / 4) + hometownWeekends + (holidays * 2 / 3));
        }
        else
        {
            result = (((48 - (decimal)hometownWeekends) * 3 / 4) + hometownWeekends + (holidays * 2 / 3));
        }

        // Printing the result
        Console.WriteLine(Math.Floor(result));
    }
}