using System;

class KSequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        int k = int.Parse(Console.ReadLine());

        input = input + " " + int.MaxValue;
        string[] numbers = input.Split(' ');
        int counter = 1;
        int prev = int.Parse(numbers[0]);
        for (int i = 1; i < numbers.Length; i++)
        {
            int numb = int.Parse(numbers[i]);
            if (numb == prev)
            {
                counter++;
            }
            else
            {
                for (int p = 0; p < counter % k; p++)
                {
                    Console.Write(prev + " ");
                }
                counter = 1;
            }
            prev = numb;
        }
    }
}
