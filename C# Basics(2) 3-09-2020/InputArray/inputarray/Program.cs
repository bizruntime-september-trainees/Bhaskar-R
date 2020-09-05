namespace inputarray
{
    using System;

    public class InputArray
    {
        static void Main(String[] args)
        {
            int[] arr = new int[5];

            Console.WriteLine("enter the array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("the array elements are:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}