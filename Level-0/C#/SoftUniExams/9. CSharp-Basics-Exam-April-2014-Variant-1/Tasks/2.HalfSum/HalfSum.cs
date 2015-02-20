using System;
using System.Linq;

class HalfSum
{
    static void Main()
    {
        // User input and declaring variables
        int n = int.Parse(Console.ReadLine());
        int[] firstNumbers = new int[n];
        int[] secondNumbers = new int[n];

        // Inputting the first N numbers
        for (int numb = 0; numb < firstNumbers.Length; numb++)
        {
            firstNumbers[numb] = int.Parse(Console.ReadLine());
        }

        // Inputting the second N numbers
        for (int numb = 0; numb < secondNumbers.Length; numb++)
        {
            secondNumbers[numb] = int.Parse(Console.ReadLine());
        }

        // Outputting the result
        if (firstNumbers.Sum() == secondNumbers.Sum())
        {
            Console.WriteLine("Yes, sum={0}", firstNumbers.Sum());
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(firstNumbers.Sum() - secondNumbers.Sum()));
        }
    }
}