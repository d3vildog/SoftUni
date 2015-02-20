using System;

class ExamSchedule
{
    static void Main()
    {
        int startingHour = int.Parse(Console.ReadLine());
        int startingMinutes = int.Parse(Console.ReadLine());
        string partOfDay = Console.ReadLine();
        int duratationHour = int.Parse(Console.ReadLine());
        int duratationMinutes = int.Parse(Console.ReadLine());

        startingHour = startingHour % 12;
        if (partOfDay == "PM")
        {
            startingHour += 12;
        }
        DateTime startTime = new DateTime(2014, 04, 09, startingHour, startingMinutes, 0);
        DateTime endTime = startTime.AddHours(duratationHour).AddMinutes(duratationMinutes);
        Console.WriteLine("{0:hh:mm:tt}", endTime);
    }
}

