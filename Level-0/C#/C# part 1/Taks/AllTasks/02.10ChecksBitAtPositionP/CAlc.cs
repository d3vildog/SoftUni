namespace _02._10ChecksBitAtPositionP
{
    using System;
    using System.Linq;

 public class CAlc
    {
       public static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int enteredNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position : ");
            int position = int.Parse(Console.ReadLine());
            int mask;
            int result;
            int moving;

            mask = 1 << position;
            result = enteredNumber & mask;
            moving = result >> position;

            Console.WriteLine(moving);
            Console.ReadLine();
        }
    }
}
