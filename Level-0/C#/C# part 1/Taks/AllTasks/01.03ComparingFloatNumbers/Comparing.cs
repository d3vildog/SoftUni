using System;
class FloatComp
{
    static void Main(string[] args)
    {
        bool isEqual;
        while (true)
        {
            Console.Write("Please enter first num or enter 0 to exit: ");
            double firstNum = double.Parse(Console.ReadLine());
            if (firstNum == 0)
            {
                break;
            }
            Console.Write("Please enter second num: ");
            double secondNum = double.Parse(Console.ReadLine());

            isEqual = Math.Abs(firstNum - secondNum) < 1e-6;
            Console.WriteLine("{0} and {1} are equal? -{2}", firstNum, secondNum, isEqual);
        }
    }
}