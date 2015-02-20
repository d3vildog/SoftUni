namespace _02._12NumberValuePositionBR
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

   public class BinaryRepresentation
    {
       public static void Main()
        {
           // Declaring variables
           int number;
           int position;
           int value;
           int mask;
           int numberAndMask = 0;

           // Input
           Console.Write("Enter number = ");
           number = int.Parse(Console.ReadLine());
           Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
           Console.Write("Enter value for the bit(0 or 1) = ");
           value = int.Parse(Console.ReadLine());
           Console.Write("Enter position = ");
           position = int.Parse(Console.ReadLine());

           // Solution
           if (value == 1)
           {
               mask = value << position;
               numberAndMask = number | mask;
           }
           else if (value == 0)
           {
               mask = ~(1 << position);
               numberAndMask = number & mask;
           }
           else
           {
               Console.WriteLine("Invalid input!!!");
           }

           // Output
           Console.WriteLine("The result of this action is = "  + numberAndMask);
           Console.WriteLine(Convert.ToString(numberAndMask, 2).PadLeft(8, '0'));
           Console.WriteLine();
           Main();
       }
    }
}
