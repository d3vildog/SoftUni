namespace System
{
    class EuclideanAlgorithmGCD
    {
        static void Main()
        {
            Console.Title = "Greatest Common Divisor (GCD) - Euclidean algorithm ";

            string divA = string.Empty;
            Console.Write("Please enter first number A= ");
            divA = Console.ReadLine();
            int divIntA = 1;

            while (int.TryParse(divA, out divIntA) == false)
            {
                Console.Write("Please enter correct number A= ");
                divA = Console.ReadLine();
            }

            string divB = string.Empty;
            Console.Write("Please enter second number B= ");
            divB = Console.ReadLine();
            int divIntB = 0;

            while (int.TryParse(divB, out divIntB) == false)
            {
                Console.Write("Please enter correct second number B= ");
                divB = Console.ReadLine();
            }

            while (divIntA != divIntB)
            {
                if (divIntA > divIntB)
                {
                    divIntA = divIntA - divIntB;
                }
                else
                {
                    divIntB = divIntB - divIntA;
                }
            }
            Console.WriteLine("GCD is " + divIntA);
            Console.ReadLine();
        }
    }
}