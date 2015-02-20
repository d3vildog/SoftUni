namespace _04._02ShowingTheSign
{
    using System;
    using System.Linq;

   public class Sign
    {
       public static void Main()
        {
           //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.
           Console.WriteLine("Enter 3 numbers... ");
           int fn = int.Parse(Console.ReadLine());
           int sn = int.Parse(Console.ReadLine());
           int tn = int.Parse(Console.ReadLine());

           if (fn > 0)
           {
               Console.WriteLine("+" + fn);
           }
           else
           {
               Console.WriteLine(fn);
           }

           if (sn > 0)
           {
               Console.WriteLine("+" + sn);
           }
           else
           {
               Console.WriteLine(sn);
           }

           if (tn > 0)
           {
               Console.WriteLine("+" + tn);
           }
           else
           {
               Console.WriteLine(tn);
           }

           Console.WriteLine();
           Main();
        }
    }
}
