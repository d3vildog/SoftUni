namespace _02._11ExtractingBits
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
            // Declaring variables
            int enteredNumber;
            int mask;
            int deleteTheBit;
            int position;

            // Input
            Console.Write("Enter number = ");
            enteredNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter position = ");
            position = int.Parse(Console.ReadLine());

            // Solution
            mask = 1 << position;
            deleteTheBit = enteredNumber ^ mask;

            // Output
            Console.WriteLine(deleteTheBit);
            Console.WriteLine();
            Main();
        }
    }
}
