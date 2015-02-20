namespace _03ComparingTwoCharLetterByLetter
{
    using System;
    using System.Linq;

   public class Program
    {
       public static void Main(string[] args)
        {
            // Write a program that compares two char arrays lexicographically (letter by letter).

            char[] array1 = { 'a', 'b', 'c' };
            char[] array2 = { 'a', 'b', 'C' };
            bool equal = true;

            if (array1.Length == array2.Length) 
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        equal = false;
                        break;
                    }
                    else
                    {
                        equal = true;
                    }
                }
            }
            else
            {
                equal = false;
            }

            Console.WriteLine(equal);
            Console.ReadKey();
        }
    }
}
