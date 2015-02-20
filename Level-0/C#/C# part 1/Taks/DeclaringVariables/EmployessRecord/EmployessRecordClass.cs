using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployessRecord
{
    class EmployessRecordClass
    {
        static void Main(string[] args)
        {   
            dynamic[] employeeNumber;
            int numberOfPpl = 0;
            Console.WriteLine("How many employess you want to add ?");
            numberOfPpl = int.Parse(Console.ReadLine());
            string[] firstName = new string[numberOfPpl];
            string[] familyName = new string[numberOfPpl];
            byte[] age = new byte[numberOfPpl];
            string[] gender = new string[numberOfPpl];
            long[] ID_Number = new long[numberOfPpl];
            employeeNumber = new dynamic[numberOfPpl];
            for (int i = 0; i < employeeNumber.Length; i++)
			{
                    Console.WriteLine();
                    Console.WriteLine(i + 1 + " Employee");

                    Console.WriteLine("Enter Employee's First name: ");
                    firstName[i] = Console.ReadLine();

                    Console.WriteLine("Enter Employee's Last name: ");
                    familyName[i] = Console.ReadLine();

                    Console.WriteLine("Enter Employee's age: ");
                    age[i] = byte.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Employee's gender: ");
                    gender[i] = Console.ReadLine();

                    Console.WriteLine("Enter Employee's ID Number: ");
                    ID_Number[i] = long.Parse(Console.ReadLine());           
            }

            Console.WriteLine();
            Console.WriteLine("You have added " + numberOfPpl + " Employee's");

            for (int i = 0; i < employeeNumber.Length; i++)
            {

                Console.WriteLine(new String('-', 55));
                Console.WriteLine("|  " + firstName[i] + " " + familyName[i] + " age: " + age[i] + " gernder: " + gender[i] + " ID Number: " + ID_Number[i] + "  |");
                Console.WriteLine(new String('-', 55));
            }

            Console.ReadLine();
        }
        
    }
}
