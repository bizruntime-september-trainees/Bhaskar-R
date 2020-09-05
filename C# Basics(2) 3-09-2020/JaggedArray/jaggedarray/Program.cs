using System;

namespace jaggedarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jarr = new int[5][];
            jarr[0] = new int[] { 1, 2, 3, 4 };
            jarr[1] = new int[] { 11, 12, 13, 14, 15 };
            jarr[2] = new int[] { 21, 22, 23, 24, 25, 26 };
            jarr[3] = new int[] { 31, 32, 33, 34, 35, 36, 37 };
            jarr[4] = new int[] { 41, 42, 43, 44, 45, 46, 47, 48 };

            for(int i = 0;i<=jarr.Length - 1; i++)
            {
                for (int j = 0; j <= jarr[i].Length - 1; j++)
                {
                    Console.Write(jarr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("done");
        }
    }
}
