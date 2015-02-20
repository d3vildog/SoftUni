using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Illuminati
{
    static void Main()
    {
        string text = Console.ReadLine().ToUpper();
        int numbVowels = 0 ;
        int sumVowels = 0;

        for (int curr = 0; curr < text.Length; curr++)
        {
            char letter = text[curr];

            if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                numbVowels++;
                sumVowels += (int)letter;
            }
        }

        Console.WriteLine(numbVowels);
        Console.WriteLine(sumVowels);
    }
}