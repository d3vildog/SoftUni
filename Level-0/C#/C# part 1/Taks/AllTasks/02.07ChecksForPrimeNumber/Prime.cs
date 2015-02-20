namespace _02._07ChecksForPrimeNumber
{
    using System;
    using System.Linq;

   public class Prime
    {
        static void Main()
        {
            string enteredValue;
            int convertedValue;
            bool result;
            int counter = 0;

            Console.Write("Enter number from 1 to 100 = ");
            enteredValue = Console.ReadLine();
            result = int.TryParse(enteredValue, out convertedValue);

            if (result && convertedValue < 100)
            {
                for (int i = 1; i <= convertedValue; i++)
                {
                    if (convertedValue % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 2)
                {
                    Console.WriteLine("Entered number is prime!");
                }
                else
                {
                    Console.WriteLine("The entered number is not prime!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input!");
                Main();
            }

            Console.WriteLine();
            Main();
        }
    }
}
