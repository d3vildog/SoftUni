namespace Arrays
{
    using System;
    using System.Linq;

   public class MultiplaingArrays
    {
        public static void Main(string[] args)
        {
            // Declaring variables
            Random rand = new Random();
            int[] array = new int[20];

            // Filling the array
            for (int i = 0; i < 20; i++)
            {
                array[i] = rand.Next(1, 21);
            }

            Console.WriteLine("This is the random numbers... ");

            // Printing out the current array
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            // Multiplying array elements by 5
            for (int i = 0; i < 20; i++)
            {
                array[i] *= 5;
            }

            Console.WriteLine("This is the multiplied elements...");

            // Printing the multiplied arrays
            foreach (var item3 in array)
            {
                Console.WriteLine(item3);
            }

            Console.ReadKey();
        }
    }
}
