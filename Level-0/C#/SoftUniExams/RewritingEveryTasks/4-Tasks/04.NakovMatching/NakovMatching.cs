using System;

class NakovsMatching
{
    static void Main(string[] args)
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();
        int limit = int.Parse(Console.ReadLine());
        bool found = false;

        for (int firstIndex = 1; firstIndex <= firstWord.Length - 1; firstIndex++)
        {
            string aLeftStr = firstWord.Substring(0, firstIndex);
            string aRightStr = firstWord.Substring(firstIndex);
            int aLeftInt = SumOfDigits(aLeftStr);
            int aRightInt = SumOfDigits(aRightStr);

            for (int secondIndex = 1; secondIndex <= secondWord.Length - 1; secondIndex++)
            {
                string bLeftStr = secondWord.Substring(0, secondIndex);
                string bRightStr = secondWord.Substring(secondIndex);
                int bLeftInt = SumOfDigits(bLeftStr);
                int bRightInt = SumOfDigits(bRightStr);

                if (Math.Abs(aLeftInt * bRightInt - aRightInt * bLeftInt) <= limit)
                {
                    found = true;
                    Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", aLeftStr, aRightStr, bLeftStr, bRightStr, Math.Abs(aLeftInt * bRightInt - aRightInt * bLeftInt));
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }

    private static int SumOfDigits(string aLeftStr)
    {
        int sum = 0;

        foreach (var str in aLeftStr)
        {
            sum += (int)str;
        }

        return sum;
    }
}