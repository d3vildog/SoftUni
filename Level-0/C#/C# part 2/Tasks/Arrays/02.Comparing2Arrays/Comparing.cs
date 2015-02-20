namespace _02.Comparing2Arrays
{
    using System;
    using System.Linq;

  public class Comparing
    {
        public static void Main(string[] args)
        {
            int[] firstArray = { 1, 2, 3 };
            int[] secondArray = { 3, 2, 1 };

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine(firstArray[i] + " is equal to " + secondArray[i]);
                }
                else
                {
                    Console.WriteLine(firstArray[i] + " is not equal to " + secondArray[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
