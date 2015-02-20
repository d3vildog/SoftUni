using System;

class BullsAndCows
{
    static void Main()
    {
        // User input and variables
        StartTheProgram();
    }

    private static void StartTheProgram()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int guessNumner = 1111; guessNumner <= 9999; guessNumner++)
        {
            int bullsFound = getBulls(secretNumber, guessNumner);
            int cowsFound = getCows(secretNumber, guessNumner);

            if (IsValid(guessNumner) && bullsFound == bulls && cowsFound == cows)
            {
                isFound = true;
                Console.Write("{0} ", guessNumner);
            }
        }

        if (!isFound)
        {
            Console.WriteLine("No");
        }
    }

    private static int getCows(int secretNumber, int guessNumner)
    {
        int cows = 0;
        char[] secret = secretNumber.ToString().ToCharArray();
        char[] guess = guessNumner.ToString().ToCharArray();

        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i] && secret[i] != '*' && guess[i] != '*')
            {
                secret[i] = '*';
                guess[i] = '*';
            }
        }

        for (int s = 0; s < secret.Length; s++)
        {
            for (int g = 0; g < guess.Length; g++)
            {
                if (secret != guess && secret[s] != '*' && guess[g] != '*' && secret[s] == guess[g])
                {
                    cows++;
                    secret[s] = '*';
                    guess[g] = '*';
                }
            }
        }

        return cows;
    }

    private static int getBulls(int secretNumber, int guessNumner)
    {
        int bulls = 0;
        char[] secret = secretNumber.ToString().ToCharArray();
        char[] guess = guessNumner.ToString().ToCharArray();

        for (int i = 0; i < secret.Length; i++)
        {
            if (secret[i] == guess[i] && secret[i] != '*' && guess[i] != '*')
            {
                bulls++;
                secret[i] = '*';
                guess[i] = '*';
            }
        }

        return bulls;
    }

    private static bool IsValid(int guessNumner)
    {
        int numb;
        bool isValid = true;

        while (guessNumner > 0)
        {
            numb = guessNumner % 10;
            guessNumner = guessNumner / 10;

            if (numb == 0)
            {
                isValid = false;
                break;
            }
        }

        return isValid;
    }
}