using System;

class MorseCodeNumber
{
    static void Main()
    {
        // Input and variables
        int number = int.Parse(Console.ReadLine());
        string numb = number.ToString();
        int nSum = SumToken(number);
        bool isFound = false;

        for (int d1 = 0; d1 <= 5; d1++)
        {
            for (int d2 = 0; d2 <= 5; d2++)
            {
                for (int d3 = 0; d3 <= 5; d3++)
                {
                    for (int d4 = 0; d4 <= 5; d4++)
                    {
                        for (int d5 = 0; d5 <= 5; d5++)
                        {
                            for (int d6 = 0; d6 <= 5; d6++)
                            {
                                int morseProduct = d1 * d2 * d3 * d4 * d5 * d6;

                                if (morseProduct == nSum)
                                {
                                    isFound = true;
                                    Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|", MorseCode(d1), MorseCode(d2), MorseCode(d3), MorseCode(d4), MorseCode(d5), MorseCode(d6));
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

    private static int SumToken(int number)
    {
        int sum = 0;

        while (number > 0 )
        {
            sum += number % 10;
            number = number / 10;
        }

        return sum;
    }

    private static string MorseCode(int numb)
    {
        string morseCode = "";

        switch (numb)
        {
            case 0:
                morseCode = "-----";
                break;
            case 1:
                morseCode = ".----";
                break;
            case 2:
                morseCode = "..---";
                break;
            case 3:
                morseCode = "...--";
                break;
            case 4:
                morseCode = "....-";
                break;
            case 5:
                morseCode = ".....";
                break;
            default:
                break;
        }

        return morseCode;
    }
}