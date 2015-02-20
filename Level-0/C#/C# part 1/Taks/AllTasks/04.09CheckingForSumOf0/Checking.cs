using System;
using System.Threading;

class l_5_task9_c_sh_part_1
{
    static bool checkInterval(int i, int j, int[] arr)
    {
        int sum = 0;
        bool result = false;
        bool isChecked = false; // check if we were in the loop
        for (int k = i; k < j; k++)
        {
            sum = sum + arr[k];
            isChecked = true;
        }
        if (sum == 0 && isChecked)
        {
            Console.Write("Subsets with zero sum:");
            for (int k = i; k < j; k++)
            {
                result = true;
                if (k < j - 1)
                {
                    Console.Write(" {0},", arr[k]);
                }
                else
                {
                    Console.Write(" {0}", arr[k]);
                }
            }
            Console.WriteLine();
        }
        return result;
    }

    static void Main()
    {
        while (true)
        {
            int[] arrInput = new int[5];
            string line;
            Console.WriteLine("Enter 5 integers");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("integer {0}:", i + 1);
                line = Console.ReadLine();
                arrInput[i] = Int32.Parse(line);
            }

            //int[] arrInput = new int[] {3, -2, -1, 1, -1};
            bool result = false;
            bool check = false;
            for (int i = 0; i < arrInput.Length; i++)
            {
                for (int j = 1; j <= arrInput.Length; j++)
                {
                    check = checkInterval(i, j, arrInput); // chek if this interval sum is 0
                    if (check)
                    {
                        result = true;
                    }
                }
            }

            if (!result)
            {
                Console.WriteLine("NO subsets with zero sum");
            }

            Console.ReadLine();

        }
    }
}