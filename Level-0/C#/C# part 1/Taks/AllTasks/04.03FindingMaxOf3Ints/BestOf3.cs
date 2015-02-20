namespace _04._03FindingMaxOf3Ints
{
    using System;
    using System.Linq;

   public class BestOf3
    {
       public static void Main()
        {
           ////Write a program that finds the biggest of three integers using nested if statements
           Console.WriteLine("Enter 3 numbers... ");
           int fn = int.Parse(Console.ReadLine());
           int sn = int.Parse(Console.ReadLine());
           int tn = int.Parse(Console.ReadLine());
           int max;

           if (fn > sn)
           {
               max = fn;
               if (fn > tn)
               {
                   max = fn;
               }
               else
               {
                   max = tn;
               }
           }
           else
           {
               max = sn;
               if (sn > tn)
               {
                   max = sn;
               }
               else
               {
                   max = tn;
               }
           }

           Console.WriteLine("The biggest number is " + max);
           Console.WriteLine();
           Main();
        }
    }
}
