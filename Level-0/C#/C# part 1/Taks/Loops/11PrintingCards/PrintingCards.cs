using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11PrintingCards
{
    class PrintingCards
    {
        static void Main(string[] args)
        {
            int numbers = 10;
            int numberOfPaints = 4;
            string[] paints = { "♠ пики", "♥ купи", "♦ карo", "♣ спатии" };
            string[] letters = {"J", "Q", "K", "A"};
            for (int k = 2; k <= numbers; k++)
            {
                switch (k)
                {
                    case 2:
                       
                        foreach (var card2 in paints)
                        {
                            Console.Write(k + " - ");
                            Console.Write(card2 != "♣ спатии" ? card2 + ", ": card2 + ".\n");
                        }
                        break;
                    case 3:
                        
                        foreach (var card2 in paints)
                        {
                            Console.Write(k + " - ");
                            Console.Write(card2 != "♣ спатии" ? card2 + ", " : card2 + ".\n");
                        }
                        break;
                    case 4:
                        
                        foreach (var card2 in paints)
                        {
                            Console.Write(k + " - ");
                            Console.Write(card2 != "♣ спатии" ? card2 + ", " : card2 + ".\n");
                        }
                        break;
                    case 5:
                        
                        foreach (var card2 in paints)
                        {
                            Console.Write(k + " - ");
                            Console.Write(card2 != "♣ спатии" ? card2 + ", " : card2 + ".\n");
                        }
                        break;
                    case 6:
                        
                        foreach (var card2 in paints)
                        {
                            Console.Write(k + " - ");
                            Console.Write(card2 != "♣ спатии" ? card2 + ", " : card2 + ".\n");
                        }
                        break;
                    case 7:
                        
                        foreach (var card2 in paints)
                        {
                            Console.Write(k + " - ");
                            Console.Write(card2 != "♣ спатии" ? card2 + ", " : card2 + ".\n");
                        }
                        break;
                    case 8:
                        
                        foreach (var card2 in paints)
                        {
                            Console.Write(k + " - ");
                            Console.Write(card2 != "♣ спатии" ? card2 + ", " : card2 + ".\n");
                        }
                        break;
                    case 9:
                        
                        foreach (var card2 in paints)
                        {
                            Console.Write(k + " - ");
                            Console.Write(card2 != "♣ спатии" ? card2 + ", " : card2 + ".\n");
                        }
                        break;
                    case 10:
                        
                        foreach (var card2 in paints)
                        {
                            Console.Write(k + " - ");
                            Console.Write(card2 != "♣ спатии" ? card2 + ", " : card2 + ".\n");
                        }
                        break;
                    default:
                        Console.WriteLine("Something is not right!!!");
                        break;
                }
            }

            foreach (var letterCards in letters )
            {
                
                foreach (var card2 in paints)
                {
                    Console.Write(letterCards + " - ");
                    Console.Write(card2 != "♣ спатии" ? card2 + ", " : card2 + ".\n");
                }
 
            }

            Console.ReadKey();

        }
    }
}
