using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3CompanyManeger
{
    class Co
    {
        static void Main(string[] args)
        {
            // Company 
            string companyName = "NEC";
            string companyAdrress = " \"Georgi Pejachevich\" №51" ;
            int companyPhoneNumber = 0988926030;
            int companyFaxNumber = 3112412;
            string companyWebSite = "https://www.google.bg/?gws_rd=ssl";

            // Manager
            string managerFirstName = "Sara";
            string managerLastName = "Bolton";
            int managerAge = 28;
            int managerPhoneNumber = 0988195812;

            Console.WriteLine("Comapny Name: {0, 23}", companyName);
            Console.WriteLine("Address - {0, 23}", companyAdrress);
            Console.WriteLine("Company phone number {0, 23} and their fax number is: {1, 23}", companyPhoneNumber, companyFaxNumber);

            Console.ReadLine();
        }
    }
}
