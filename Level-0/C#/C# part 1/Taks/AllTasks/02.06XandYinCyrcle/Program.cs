namespace _02._06XandYinCyrcle
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main(string[] args)
        {   // (x - center_x)^2 + (y - center_y)^2 < radius^2
            // Declaring variables 
            int inputedX;
            int inputedY;
            int radius = 5;
            int center = 1;
            bool output;

            // Input
            Console.Write("Enter number for X = ");
            inputedX = int.Parse(Console.ReadLine());
            Console.Write("Enter number for Y = ");
            inputedY = int.Parse(Console.ReadLine());

            // Checks are x and y in the circle
            output = Math.Pow(inputedX - center, 2) + Math.Pow(inputedY - center, 2) < radius * radius; 
        
            // Output
            if (output)
            {
                Console.WriteLine("The entered {0} and {1} are in the circle!", inputedX, inputedY);
            }
            else
            {
                Console.WriteLine("{0} and {1} are not in the circle!", inputedX, inputedY);
            }

            Console.ReadKey();
        }
    }
}
