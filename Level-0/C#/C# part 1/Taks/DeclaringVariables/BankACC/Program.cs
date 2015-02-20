
using System;
using System.Collections.Generic;

class BankAccount
{
    static void Main()
    {
        Console.WriteLine(new string('-', 60)); //create new string who writing in console 52 "-" (minus) like devider

        Console.WriteLine("Personal Information:");
        Console.WriteLine(); //empty row
        string firstName = "Zdravko";
        string middleName = "Kamenov";
        string lastName = "Zhelyazkov";
        object fullName = firstName + " " + middleName + " " + lastName;
        Console.WriteLine(fullName);

        Console.WriteLine(new string('-', 60)); //create new string who writing in console 52 "-" (minus) like devider

        Console.WriteLine("Amount Information:");
        Console.WriteLine(); //empty row
        decimal balance = 74.7M;
        string bankName = "Alianz Bank Bulgaria";
        string IBAN = "BH 56 AAAA 0000 0123 4567 89";
        string bicCode = "BUINBGSF";
        Console.WriteLine("'{0}' has a balance of '{1} billions',\nIBAN '{2}' and BIC code '{3}'", bankName, balance, IBAN, bicCode);

        Console.WriteLine(new string('-', 60)); //create new string who writing in console 52 "-" (minus) like devider

        Console.WriteLine("Credit Cards:");
        Console.WriteLine(); //empty row
        long firstCreditCard = 4207670054361434;
        long secondCreditCard = 4328810002719770;
        long thirdCreditCard = 5466160175050358; // or Int64 thirdCreditCard = 5 466 160 175 050 358;
        Console.WriteLine("First credit card has '{0}' number.\nSecond credit card has '{1}' number.\nThird credit card has '{2}' number.", firstCreditCard, secondCreditCard, thirdCreditCard);

        Console.ReadLine();
    }
}
