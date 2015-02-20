using System;

class InsideTheBuilding
{
    static void Main()
    {
        int sizeOfTheBuilding = int.Parse(Console.ReadLine());

        for (int times = 0; times < 5; times++)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x >= 0 && x <= 3 * sizeOfTheBuilding && y >= 0 && y <= 4 * sizeOfTheBuilding)
            {
                if ((x >= 0 && x <= sizeOfTheBuilding || x >= sizeOfTheBuilding * 2 && x <= sizeOfTheBuilding * 3) && y <= sizeOfTheBuilding)
                {
                    Console.WriteLine("inside");
                }
                else if ((x >= sizeOfTheBuilding && x <= sizeOfTheBuilding * 2) && y <= sizeOfTheBuilding * 4)
                {
                    Console.WriteLine("inside");
                }
                else
                {
                    Console.WriteLine("outside");
                }
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}