namespace _01MultiplingBy5
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
            // Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

           // Declaring variables
            int[] array = new int[20];

            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 20) * 5;
            }

            foreach (var numb in array)
            {
                Console.WriteLine(numb);
            }

            Console.ReadKey();
        }
    }
}
