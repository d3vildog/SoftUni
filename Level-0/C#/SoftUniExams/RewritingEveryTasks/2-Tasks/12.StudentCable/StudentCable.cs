using System;

class StudentCables
{
    static void Main()
    {
        int numberOfCables = int.Parse(Console.ReadLine());
        int studentCable = 0;
        int wholeCable = 0;
        int leftCable = 0;
        int discarted = 0;

        for (int i = 0; i < numberOfCables; i++)
        {
            int cableLenght = int.Parse(Console.ReadLine());
            string measured = Console.ReadLine();

            if (measured == "meters")
            {
                cableLenght = cableLenght * 100;
            }
            if (cableLenght < 20)
            {
                discarted++;
                continue;
            }

            wholeCable = wholeCable + cableLenght;
        }

        wholeCable = wholeCable - ((numberOfCables - 1 - discarted) * 3);
        studentCable = wholeCable / 504;
        leftCable = wholeCable % 504;

        Console.WriteLine(studentCable);
        Console.WriteLine(leftCable);
    }
}