using System;

class BullsAndCows
{
    const int Digits = 4;

    static void Main()
    {
        int secretNumber = int.Parse(Console.ReadLine());
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());
        int result = 0;

        for (int guessNumber = 1111; guessNumber <= 9999; guessNumber++)
        {
            
            int foundBulls = getBulls(secretNumber, guessNumber);
            int foundCows = getCows(secretNumber, guessNumber);

            if (bulls == foundBulls && cows == foundCows && guessNumber.ToString().IndexOf('0') == -1)
            {
                Console.Write(guessNumber);
                Console.Write(" ");
                result++;
            }
        }

        if (result == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int getCows(int secretNumber, int guessNumber)
    {
        char[] secNum = secretNumber.ToString().ToCharArray(); // .PadLeft(Digits, '0') 
        char[] guessNum = guessNumber.ToString().ToCharArray(); //.PadLeft(Digits, '0')
        int cowCounter = 0;

        for (int gB = 0; gB < Digits; gB++)
        {
            if (secNum[gB] == guessNum[gB])
            {
                secNum[gB] = '*';
                guessNum[gB] = '*';
            }
        }

        for (int sN = 0; sN < Digits; sN++)
        {
            for (int gN = 0; gN < Digits; gN++)
            {
                if (secNum[sN] == guessNum[gN] && secNum[sN] != '*' && guessNum[gN] != '*')
                {
                    cowCounter++;
                    secNum[sN] = '*';
                    guessNum[gN] = '*';
                }
            }
        }

        return cowCounter;
    }

    private static int getBulls(int secretNumber, int guessNumber)
    {
        string secNum = secretNumber.ToString();
        string guessNum = guessNumber.ToString();
        int bullCounter = 0;

        if (secNum[0] == guessNum[0])
        {
            bullCounter++;
        }
        if (secNum[1] == guessNum[1])
        {
            bullCounter++;
        }
        if (secNum[2] == guessNum[2])
        {
            bullCounter++;
        }
        if (secNum[3] == guessNum[3])
        {
            bullCounter++;
        }
        

        return bullCounter;
    }
}