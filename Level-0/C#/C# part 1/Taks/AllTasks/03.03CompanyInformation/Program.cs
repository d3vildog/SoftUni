using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._03CompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. Write a program that reads the information about a company and its manager and prints them on the console.
            dynamic[] companyInformation = new dynamic[6];
            dynamic[] managerInformation = new dynamic[4];

            for (int i = 0; i < companyInformation.Length; i++ )
            {
                companyInformation[i] = Console.ReadLine();
            }

            for (int i = 0; i < managerInformation.Length; i++)
            {
                managerInformation[i] = Console.ReadLine();
            }

            foreach (var company in companyInformation)
            {
                Console.WriteLine(company);
            }

            foreach (var manager in managerInformation)
            {
                Console.WriteLine(manager);
            }

            Console.ReadKey();
        }
    }
}
