namespace _02._05CheckingThirdBit
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int inputNumber;
            bool checkingNumber;
            string entered;

            Console.Write("Enter number = ");
            entered = Console.ReadLine();
            checkingNumber = int.TryParse(entered, out inputNumber);
            if (checkingNumber)
            {
                Console.WriteLine("The third bit of this number is {0}", (inputNumber >> 3 == 1) ? 1 : 0);
                Main();
            }
            else
            {
                Console.WriteLine("You have entered invalid value!");
                Main();
            }

            Console.ReadKey();
        }
    }
}
