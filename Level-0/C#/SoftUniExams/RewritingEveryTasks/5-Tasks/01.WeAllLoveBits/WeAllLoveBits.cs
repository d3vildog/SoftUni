using System;

class WeAllLoveBits
{
    static void Main()
    {
        // user input and variables
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            int newNumber = 0;

            while (number > 0)
            {
                newNumber = newNumber << 1;

                if ((number & 1) == 1)
                {
                    newNumber = newNumber | 1;
                }

                number = number >> 1;
            }
            Console.WriteLine(newNumber);
        }
    }
}