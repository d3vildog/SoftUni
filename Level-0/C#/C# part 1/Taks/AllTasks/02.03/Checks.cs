public namespace _02._03
{
    using System;
    using System.Linq;

    {
        static void Main(string[] args)
        {
            //Input
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if((number / 100) % 10 == 7)  //if ((number / 100) % 10 == 7)
            {
                Console.WriteLine("The third digit(left-right) is seven!");
            }
            else
            {
                Console.WriteLine("The third digit(left-right) is not seven!");
            }
            Console.ReadLine();

        }
    }
}
