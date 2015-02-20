using System;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        string projectionType = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int columns = int.Parse(Console.ReadLine());
        decimal sum = 0;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        if (projectionType == "Premiere")
        {
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    sum = sum + 12.00m;
                }
            }
        }
        else if (projectionType == "Normal")
        {
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    sum = sum + 7.50m;
                }
            }
        }
        else if (projectionType == "Discount")
        {
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    sum = sum + 5.00m;
                }
            }
        }

        Console.WriteLine("{0} leva", sum);
    }
}