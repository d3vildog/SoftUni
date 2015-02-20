namespace _04._08ChangingUserInputWithSwitch
{
    using System;
    using System.Linq;

   public class Changing
    {
       public static void Main()
        {
            //Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

           while (true)
            { //string.Equals(input, "Integer", StringComparison.OrdinalIgnoreCase)
              //Console.WriteLine("What you want to write: \nInteger, Double or String?");
              //string input = Console.ReadLine();
                Console.WriteLine("Choose what kind of variable you would like to enter.");
                Console.Write("For int press 1, for double - 2 and for string - 3: ");
                string userInput = Console.ReadLine();
                byte userChoice;
                bool check = byte.TryParse(userInput, out userChoice);
                bool isInputCorrect;

                if (check)
                {
                    switch (userChoice)
                    {
                        case 1:
                            Console.Write("Enter your int variable: ");
                            long intChoice;
                            isInputCorrect = long.TryParse(Console.ReadLine(), out intChoice);
                            if (isInputCorrect)
                            {
                                Console.WriteLine(intChoice + 1);
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input! Please Try again!");
                                Main();
                            }
                            break;
                        case 2:
                            Console.Write("Enter your double variable: ");
                            double doubleChoice;
                            isInputCorrect = double.TryParse(Console.ReadLine(), out doubleChoice);
                            if (isInputCorrect)
                            {
                                Console.WriteLine(doubleChoice + 1.0);
                            }
                            else
                            {
                                Console.WriteLine("Incorrect input! Please Try again!");
                                Main();
                            }
                            break;
                        case 3:
                            Console.Write("Enter your string variable: ");
                            string strChoice = Console.ReadLine();
                            Console.WriteLine(strChoice + "*");
                            break;
                        default:
                            Console.WriteLine("Incorrect input! Please Try again!");
                            Main();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input! Please Try again!");
                    Main();
                }

               Console.ReadKey();
        }
    }
}
