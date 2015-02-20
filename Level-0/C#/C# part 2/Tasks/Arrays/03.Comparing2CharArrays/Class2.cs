using System;

public class CharArrays
{
    public static void Main()
    {
        Console.Write("Enter the first word to compare: ");
        char[] firstArray = Console.ReadLine().ToLower().ToCharArray();

        Console.Write("Enter the second word to compare: ");
        char[] secondArray = Console.ReadLine().ToLower().ToCharArray();

        bool areEqual = true;

        for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
        {
            if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("'{0}' comes earlier lexicographically, than '{1}'.", new string(firstArray), new string(secondArray));
                areEqual = false;
                break;
            }

            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("'{0}' comes earlier lexicographically, than '{1}'.", new string(secondArray), new string(firstArray));
                areEqual = false;
                break;
            }
        }

        if (areEqual && firstArray.Length == secondArray.Length)
        {
            Console.WriteLine("The two arrays are equal.");
        }
        else if (areEqual && firstArray.Length < secondArray.Length)
        {
            Console.WriteLine("'{0}' comes earlier lexicographically, than '{1}'.", new string(firstArray), new string(secondArray));
        }
        else if (areEqual && firstArray.Length > secondArray.Length)
        {
            Console.WriteLine("'{0}' comes earlier lexicographically, than '{1}'.", new string(secondArray), new string(firstArray));
        }

        Console.ReadKey();

    }
}