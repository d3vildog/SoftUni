using System;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] str = { 'k', 'n', 'p', 's' };
        bool isFound = false;

        for (int d1 = 0; d1 < str.Length; d1++)
        {
            for (int d2 = 0; d2 < str.Length; d2++)
            {
                for (int d3 = 0; d3 < str.Length; d3++)
                {
                    for (int d4 = 0; d4 < str.Length; d4++)
                    {
                        string left = "" + str[d1] + str[d2] + str[d3] + str[d4];
                        int leftSide = transform(left);
                        for (int d5 = 0; d5 < str.Length; d5++)
                        {
                            for (int d6 = 0; d6 < str.Length; d6++)
                            {
                                for (int d7 = 0; d7 < str.Length; d7++)
                                {
                                    for (int d8 = 0; d8 < str.Length; d8++)
                                    {
                                        string right = "" + str[d5] + str[d6] + str[d7] + str[d8];
                                        int rightSide = transform(right);
                                        if (Math.Abs(leftSide - rightSide) == diff)
                                        {
                                            Console.WriteLine(left + right);
                                            isFound = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }

    private static int transform(string str)
    {
        int sum = 0;
        foreach (var element in str)
        {
            switch (element)
            {
                case 'k':
                    sum += 1;
                    break;
                case 'n':
                    sum += 4;
                    break;
                case 'p':
                    sum += 5;
                    break;
                case 's':
                    sum += 3;
                    break;
                default:
                    break;
            }
        }

        return sum;
    }
}
