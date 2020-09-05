using System;

public class InputArray
{
	static void main(String[] args)
    {
        int[] arr = new int[5];

        Console.WriteLine("enter the array elements");
        for(int i = 0;i< arr.Length;i++)
        {
            int arr[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine($"the array elements are:{arr[i]}");
        }
}
