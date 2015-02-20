namespace _02ComparingTwoArrays
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main()
        {
            //Write a program that reads two arrays from the console and compares them element by element.

            int[] firstArray = { 3, 2, 1 };
            int[] secondArray = { 1, 2, 3 };

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine(firstArray[i] + " match with " + secondArray[i]);
                }
                else
                {
                    Console.WriteLine(firstArray[i] + " do not match with " + secondArray[i]);
                }
            }

            Console.ReadKey();

        }
    }
}
