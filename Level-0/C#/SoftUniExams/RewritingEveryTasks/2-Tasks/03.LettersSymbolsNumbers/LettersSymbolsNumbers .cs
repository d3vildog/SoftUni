using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int lettersSum = 0;
        int numbersSum = 0;
        int symbolsSum = 0;

        for (int i = 0; i < n; i++)
        {
            string text = Console.ReadLine().ToUpper();

            for (int i2 = 0; i2 < text.Length; i2++)
            {
                char current = text[i2];

                if (char.IsLetter(current))
                {
                    lettersSum += (current - 'A' + 1) * 10;
                }
                else if (char.IsDigit(current))
                {
                    numbersSum += (int)char.GetNumericValue(current) * 20;
                }
                else if (char.IsPunctuation(current))
                {
                    symbolsSum += 200;
                }
                else if (char.IsSymbol(current))
                {
                    symbolsSum += 200;
                }
            }
        }

        Console.WriteLine(lettersSum);
        Console.WriteLine(numbersSum);
        Console.WriteLine(symbolsSum);
    }
}