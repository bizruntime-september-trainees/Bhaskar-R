using System;
using System.Collections.Generic;

namespace listexamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List <int> list = new List <int>();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            for(int i=0;i<=list.Count-1;i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("After remove element in list:");
            list.Remove(20);
            foreach(int list1 in list)
            {
                Console.WriteLine(list1);
            }
            Console.WriteLine("Finished");
        }
    }
}
