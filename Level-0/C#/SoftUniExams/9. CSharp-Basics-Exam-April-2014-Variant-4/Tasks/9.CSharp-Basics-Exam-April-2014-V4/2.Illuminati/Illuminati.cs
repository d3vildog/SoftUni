using System;

class Illuminati
{
    static void Main()
    {
        string userinput = Console.ReadLine();
        userinput = userinput.ToUpper();
        int sum = 0;
        int numberOfVowels = 0;

        foreach (var str in userinput)
        {
            if (str == 'A' || str == 'E' || str == 'I' || str == 'O' || str == 'U')
            {
                sum = sum + str;
                numberOfVowels++;
            }
        }

        Console.WriteLine(numberOfVowels);
        Console.WriteLine(sum);
    }
}
