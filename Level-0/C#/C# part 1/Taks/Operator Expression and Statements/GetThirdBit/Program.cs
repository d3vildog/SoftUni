using System;

class ThirdBitValue
{
    static void Main()
    {
        string inputInt;
        int numberToCheck;
        bool validInt;

        Console.WriteLine("Input number between {0} and {1}", Int32.MinValue, Int32.MaxValue);
        inputInt = Console.ReadLine();
        validInt = Int32.TryParse(inputInt, out numberToCheck);
        if (validInt)
        {
            Console.WriteLine("The 3rd bit of your integer is {0}", ((numberToCheck >> 3) & 1) == 1 ? 1 : 0);
        }
        else
        {
            Console.WriteLine("This number is invalid!");
            Main();
        }
        Console.ReadLine();

    }
}