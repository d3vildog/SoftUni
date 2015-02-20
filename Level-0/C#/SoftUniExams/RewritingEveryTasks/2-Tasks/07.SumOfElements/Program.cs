using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split(' ');
        long sum = 0;
        long maxNumber = 0;

        for (int main = 0; main < text.Length; main++)
        {
            sum += long.Parse(text[main]);

            if (long.Parse(text[main]) > maxNumber)
	        {
                maxNumber = long.Parse(text[main]);
	        }
        }

        if (sum == 2 * maxNumber)
        {
            Console.WriteLine("Yes, sum=" + maxNumber);
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(sum - (2 * maxNumber)));
        }
    }
}