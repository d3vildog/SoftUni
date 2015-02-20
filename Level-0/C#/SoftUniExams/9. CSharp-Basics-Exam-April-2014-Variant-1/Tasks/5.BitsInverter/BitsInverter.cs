using System;

class BitsInverter
{
    static void Main()
    {
       // User input and initializing the variables
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int index = 0;

        // Inverting the bits and printing the result
        for (int number = 0; number < n; number++)
        {
            int numb = int.Parse(Console.ReadLine());

            for (int bit = 7; bit >= 0; bit--)
            {
                index++;
                if (step == 1 || index % step == 1)
                {
                    numb = numb ^ (1 << bit);
                }
            }

            Console.WriteLine(numb);
        }
    }
}
