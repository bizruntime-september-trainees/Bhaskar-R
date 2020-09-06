using System;
using System.Collections.Generic;
namespace GenericListMethod1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(60);
            Console.WriteLine("Capacity of list : " + list.Capacity);

            Console.WriteLine("Printing the List items using for loop:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + "  ");
            }
            Console.WriteLine();

            list.Remove(30);

            list.RemoveAt(3);

            Console.WriteLine("List items after removing the value 30 :");
            foreach (int item in list)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

            list.Insert(2, 25);

            Console.WriteLine("List items after inserting the value 25 in the index 2");
            foreach (int item in list)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

            List<int> newList = new List<int>(list);
            Console.WriteLine("Initial capacity of new list collection:" + newList.Capacity);
            Console.WriteLine("Printing the new List items which is created from the old list");
            foreach (int item in newList)
            {
                Console.Write(item + "  ");
            }
        }
    }

}