using System;

class MagicString
{
    static void Main()
    {
        // User input and variables
        int diff = int.Parse(Console.ReadLine());
        bool isFound = false;
        string[] letters = {"k", "n", "p", "s"};

        for (int d1 = 0; d1 < letters.Length; d1++)
        {
            for (int d2 = 0; d2 < letters.Length; d2++)
            {
                for (int d3 = 0; d3 < letters.Length; d3++)
                {
                    for (int d4 = 0; d4 < letters.Length; d4++)
                    {
                        string left = "" + letters[d1] + letters[d2] + letters[d3] + letters[d4];
                        int leftWeight = Sum(left);

                        for (int d5 = 0; d5 < letters.Length; d5++)
                        {
                            for (int d6 = 0; d6 < letters.Length; d6++)
                            {
                                for (int d7 = 0; d7 < letters.Length; d7++)
                                {
                                    for (int d8 = 0; d8 < letters.Length; d8++)
                                    {
                                        string right = "" + letters[d5] + letters[d6] + letters[d7] + letters[d8];
                                        int rightWeight = Sum(right);

                                        if (Math.Abs(leftWeight - rightWeight) == diff)
                                        {
                                            isFound = true;
                                            Console.WriteLine(left + right);
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

    private static int Sum(string str)
    {
        int sum = 0;

        foreach (var letter in str)
        {
            switch (letter)
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