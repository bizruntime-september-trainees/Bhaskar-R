using System;
using System.Collections.Generic;

namespace SortedList
{
    class Program
    {
        static void Main(string[] args)
        {             
            SortedList<int, string> sortedlist = new SortedList<int, string>();
            
            sortedlist.Add(1, "Sunday");
            sortedlist.Add(2, "Monday");
            sortedlist.Add(3, "Tuesday");
            sortedlist.Add(4, "Wednesday");
            sortedlist.Add(5, "Thusday");
            sortedlist.Add(6, "Friday");
            sortedlist.Add(7, "Saturday");
             
            Console.WriteLine("The elements in the SortedList are:");
            foreach (KeyValuePair<int, string> pair in sortedlist)
            {
                Console.WriteLine("{0} => {1}", pair.Key, pair.Value);
            }
            IList<int> ilistKeys = sortedlist.Keys;
            Console.WriteLine();
            Console.WriteLine("The keys are:");
            Console.Write("{");
            foreach (int i in ilistKeys)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine("}");

           
             Console.WriteLine("The Values are:");
             Console.WriteLine();
             Console.Write("{");
            
            foreach (string i in sortedlist.Values)
            {
                Console.Write(i + ",");
            }
            
           Console.WriteLine("}");
            Console.WriteLine("The key 1 contain in the SortedList:" + sortedlist.ContainsKey(1));
            Console.WriteLine("The key 50 contain in the SortedList:" + sortedlist.ContainsKey(50));
            Console.WriteLine("The value Sunday contain in the SortedList:" + sortedlist.ContainsValue("Sunday"));
            Console.WriteLine("The value Friday contain in the SortedList:" + sortedlist.ContainsValue("summer"));
            Console.WriteLine("The index value of the key 4 is:" + sortedlist.IndexOfKey(4));
            Console.WriteLine("The index value of the Monday     is:" + sortedlist.IndexOfValue("Monday"));
            sortedlist.Remove(1);
            sortedlist.Remove(6);
            Console.WriteLine("After remove some elements the sortedlist is as:");
            foreach (KeyValuePair<int, string> pair1 in sortedlist)
            {
                Console.WriteLine("{0} => {1}", pair1.Key, pair1.Value);
            }


        }
    }
}
