using System;

class Pairs
{
    static void Main()
    {
        string userLine = Console.ReadLine();
        string[] number = userLine.Split();

        int firstNumber = int.Parse(number[0]);
        int secondNumber = int.Parse(number[1]);
        int prevSum = firstNumber + secondNumber;

        int maxdiff = 0;
        for (int i = 2; i < number.Length; i+=2)
        {
            firstNumber = int.Parse(number[i]);
            secondNumber = int.Parse(number[i + 1]);
            int lastSum = firstNumber + secondNumber;
            int diff = Math.Abs(prevSum - lastSum);
            maxdiff = Math.Max(diff, maxdiff);
            prevSum = lastSum;
        }

        if (maxdiff == 0)
        {
            Console.WriteLine("Yes, value=" + prevSum);
        }
        else
        {
            Console.WriteLine("No, maxdiff=" + maxdiff);
        }
    }
}
