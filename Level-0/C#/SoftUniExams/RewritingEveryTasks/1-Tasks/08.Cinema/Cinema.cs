using System;

class Cinema
{
    static void Main()
    {
        // Globalization Dot(.)
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        // User input
        string projectionType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());

        // Solution
        decimal result = 0;

        if (projectionType == "Premiere")
        {
            result = rows * columns * 12.00m;
        }
        else if (projectionType == "Normal")
        {
            result = rows * columns * 7.50m;
        }
        else if (projectionType == "Discount")
        {
            result = rows * columns * 5.00m;
        }

        // Output
        Console.WriteLine(result + " leva");
    }
}