using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
#if DEBUG
            Console.WriteLine("start:   " + Convert.ToString(num, 2));
#endif 
            int result = 0;
            while(num > 0)
            {
                int lastBit = num & 1;
                num = num >> 1;
                result = result << 1;
                result = result | lastBit;
#if DEBUG
                Console.WriteLine("num:     " + Convert.ToString(num, 2));
                Console.WriteLine("result:  " + Convert.ToString(result, 2));
                Console.ReadLine();
#endif
            }
            Console.WriteLine(result);
        }
    }
}