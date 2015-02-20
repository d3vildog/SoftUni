using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01._10FirmRecords
{
    class Records
    {
        static void Main(string[] args)
        {

            //first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999). 
            dynamic[] Employee1 = new dynamic[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Enter personal data: ");
                Employee1[i] = Console.ReadLine();
            }

            foreach (dynamic jurk in Employee1)
            {
                Console.WriteLine(jurk);
            }

            Console.ReadKey();


        }
    }
}
