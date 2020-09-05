using System;
using System.Collections.Immutable;
using System.Linq;

namespace Arrays
{
    class Program
    {
        public static void Main()
        {

            
            int[] arr = { 1, 9, 6, 7, 5, 9 };
            
            Array.Sort(arr);

           // Array.Reverse(arr);
             
            foreach (int value in arr)
            {
               // Console.WriteLine(value + " ");
                Console.Write($"{value} ");
            }
            Console.WriteLine();
            Console.WriteLine(arr.Sum());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Average());

        }
    }
}
