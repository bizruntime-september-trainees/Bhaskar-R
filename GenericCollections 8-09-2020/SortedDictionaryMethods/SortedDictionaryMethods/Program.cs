using System;
using System.Collections.Generic;
using System.Linq;

namespace SortedDictionaryMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedDictionary<int, string> sorteddictionary = new SortedDictionary<int, string>();
            sorteddictionary.Add(1, "January");
            sorteddictionary.Add(2, "Feburary");
            sorteddictionary.Add(3, "March");
            sorteddictionary.Add(4, "April");
            sorteddictionary.Add(5, "May");
            sorteddictionary.Add(6, "June");
            sorteddictionary.Add(7, "July");
            sorteddictionary.Add(8, "August");
            sorteddictionary.Add(9, "September");
            sorteddictionary.Add(10, "October");
            sorteddictionary.Add(11, "November");
            sorteddictionary.Add(12, "December");

            foreach (KeyValuePair<int, string> pair in sorteddictionary)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }

            Console.WriteLine("The key 12 contain in the sorteddictionary:" + sorteddictionary.ContainsKey(12));         
            Console.WriteLine("The key 14 contain in the sorteddictionary:" + sorteddictionary.ContainsKey(14));
            Console.WriteLine("The value April contain in the sorteddictionary:" + sorteddictionary.ContainsValue("April"));
            Console.WriteLine("The value Sunday contain in the sorteddictionary:" + sorteddictionary.ContainsValue("Sunday"));
            foreach (int n in sorteddictionary.Keys)
            {
                Console.WriteLine("key={0}", n);
            }
            foreach (String n in sorteddictionary.Values)
            {
                Console.WriteLine("Values={0}", n);
            }

            foreach (KeyValuePair<int, string> pair in sorteddictionary)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }

            sorteddictionary.Remove(10);
            sorteddictionary.Remove(11);
            sorteddictionary.Remove(12);
            Console.WriteLine("After remal the keys the sorteddictionary is as.");
            foreach (KeyValuePair<int, string> pair in sorteddictionary)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }
            Console.WriteLine("The total number of key/value pair in sorteddictionary is:" + sorteddictionary.Count);
        }

    }

}
