using System;

class Workhours
{
    static void Main()
    {
        // User input
        int requiredWorkHours = int.Parse(Console.ReadLine());
        decimal availableDays = int.Parse(Console.ReadLine()) * 0.90m;
        int productivity = int.Parse(Console.ReadLine());

        // Solution
        decimal result = 0;
        result = Math.Floor((availableDays * 12) * (productivity / 100m));
        int diff =(int)result - requiredWorkHours;

        if (diff >= 0)
        {
            Console.WriteLine("Yes\n" + diff);
        }
        else 
        {
            Console.WriteLine("No\n" + diff);
        }
    }
}