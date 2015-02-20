using System;

class NumbersDividedBy5
{
    static void Main()
    {
        int numberA, numberB, count;
        string input;

        // изисква въвеждане на долна и горна граница на диапазона
        do
        {
            Console.Write("Въведете число А: ");
            input = Console.ReadLine();
        }
        while (!(int.TryParse(input, out numberA) && (numberA > 0)));

        do
        {
            Console.Write("Въведете число B: ");
            input = Console.ReadLine();
        }
        while (!(int.TryParse(input, out numberB) && (numberB > 0)));

        // решение, когато диапазонът включва само 1 число
        if (numberA == numberB)
        {
            count = (numberA % 5) == 0 ? 1 : 0;
            Console.WriteLine("Броят на числата в диапазона ({0} .. {1}), които се делят на 5 е {2}. \n", numberA, numberB, count);
            return;
        }

        // решение, когато долната или горната граница или и двете граници на диапазона са кратни на 5
        if ((numberA % 5 == 0) || (numberB % 5 == 0))
        {
            count = ((Math.Abs(numberB - numberA) - 1) / 5) + ((numberA % 5) == 0 ? 1 : 0) + ((numberB % 5) == 0 ? 1 : 0);
            Console.WriteLine("Броят на числата в диапазона ({0} .. {1}), които се делят на 5 е {2}. \n", Math.Min(numberA, numberB), Math.Max(numberA, numberB), count);
        }
        else
        {
            // решение, когато и двете граници не са кратни на 5 
            // тогава има разлика между (4..6) и (6..9) и (1..9)
            // затова трябва да се провери колко далеч са долната/горната граница на диапазона от първото/последното число, което е кратно на 5
            count = ((Math.Abs(numberB - numberA) - 1) / 5) + (((Math.Min(numberA, numberB) % 5) + 5 - (Math.Max(numberA, numberB) % 5)) / 5);
            Console.WriteLine("Броят на числата в диапазона ({0} .. {1}), които се делят на 5 е {2}. \n", Math.Min(numberA, numberB), Math.Max(numberA, numberB), count);
        }
        Console.ReadLine();

    }
}