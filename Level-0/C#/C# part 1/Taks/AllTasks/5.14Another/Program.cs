using System;

class Program
{
    static int br = 1;
    static void toSpiral(ref int[,] arr)
    {
        for (int i = arr.GetUpperBound(0), j = 0; i >= 0; i--, j++)
        {
            for (int k = j; k < i; k++)
            {
                arr[j, k] = br;
                br++;
            }
            for (int k = j; k < i; k++)
            {
                arr[k, i] = br;
                br++;
            }
            for (int k = i; k > j; k--)
            {
                arr[i, k] = br;
                br++;
            }
            for (int k = i; k > j; k--)
            {
                arr[k, j] = br;
                br++;
            }
        }
        for (int i = 0; i < arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j < arr.GetUpperBound(1); j++)
            {
                if (arr[i, j] == 0) { arr[i, j] = br; br++; }
            }
        }
    }
    static void Main(string[] args)
    {
        int n = 7;
        int[,] arr = new int[n, n];
        toSpiral(ref arr);
        printArr(arr);

        Console.ReadKey();
    }

    private static void printArr(int[,] arr)
    {
        for (int i = 0; i < arr.GetUpperBound(0) + 1; i++)
        {
            for (int j = 0; j < arr.GetUpperBound(0) + 1; j++)
            {
                Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}