using System;

class HourGlass
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        for (int i = 0; i <= n / 2; i++)
        {
            string dots = new string('.', i);
            string asterisk = new string('*', n - (2 * i));
            Console.WriteLine("{0}{1}{0}", dots, asterisk);
        }

        for (int i = n / 2 - 1; i >= 0; i--)
        {
            string dots = new string('.', i);
            string asterisk = new string('*', n - (2 * i));
            Console.WriteLine("{0}{1}{0}", dots, asterisk);
        }
    }
}