namespace _05._11PrintingCardNames
{
    using System;
    using System.Linq;

   public class PrintingCardsPaint
    {
       public static void Main()
        {
            ////Write a program that prints all possible cards from a standard deck of 52 cards (without jokers). The cards should be printed with their English names. Use nested for loops and switch-case.
            
            // Declaring variables
            string[] cardsValue = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] cardPaint = { "spades", "hearts", "diamonds", "clubs" };

            // Printing Cards
            for (int cV = 0; cV < cardsValue.Length; cV++)
            {
                for (int cP = 0; cP < cardPaint.Length; cP++)
                {
                    Console.WriteLine(cardsValue[cV] + " - " + cardPaint[cP]);
                }
            }

            Console.ReadLine();
        }
    }
}
