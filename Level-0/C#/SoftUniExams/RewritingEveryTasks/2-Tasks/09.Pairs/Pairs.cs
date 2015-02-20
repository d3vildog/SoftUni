using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pairs
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split(' ');
        int sum = 0;
        int prev = int.Parse(text[0]);
        int next = int.Parse(text[1]);
        int pair1 = prev + next;
        bool found = false;
        int maxdiff = int.MinValue;

        if (text.Length == 2)
        {
            found = true;
            sum = pair1;
        }
        // 2 4 4 0
        for (int i = 2; i < text.Length; i+=2)
        {
            prev = int.Parse(text[i]);
            next = int.Parse(text[i + 1]);
            int pair2 = prev + next;

            if (pair1 == pair2)
            {
                sum = pair1;
                found = true;
            }
            else
            {
                found = false;
                int diff = Math.Abs(pair1 - pair2);
                maxdiff = Math.Max(maxdiff, diff);
            }

            pair1 = pair2;
        }

        if (found)
        {
            Console.WriteLine("Yes, value=" + pair1);
        }
        else
        {
            Console.WriteLine("No, maxdiff=" + maxdiff);
        }
    }
}