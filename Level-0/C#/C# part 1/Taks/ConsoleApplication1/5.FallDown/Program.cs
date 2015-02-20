using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.FallDown
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int[] nums = new int[8];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < 8; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
            for (int j = 0; j < 8; j++)
            {
                string numToString = Convert.ToString(nums[j], 2).PadLeft(8, '0');
                Console.WriteLine(numToString);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();
            //solution
            for (int i = 0; i < 8; i++)
            {
                for (int line = 7; line > 0; line--)
                {
                    for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                    {
                        if ((nums[line] >> bitPosition & 1) == 0 && (nums[line - 1] >> bitPosition & 1) == 1)
                        {
                            nums[line] |= (1 << bitPosition);
                            nums[line-1] ^= (1 << bitPosition);
                        }
                    }

                }
                for (int j = 0; j < 8; j++)
                {
                    string numToString = Convert.ToString(nums[j], 2).PadLeft(8, '0');
                    Console.WriteLine(numToString);
                }
                Console.WriteLine();
            }

            ////output
            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
