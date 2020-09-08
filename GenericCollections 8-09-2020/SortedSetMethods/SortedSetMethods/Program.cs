using System;
using System.Collections.Generic;

namespace SortedSetMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> sortedset1 = new SortedSet<string>();

            sortedset1.Add("MCA");

            sortedset1.Add("MBA");

            sortedset1.Add("MTECH");

            SortedSet<string> sortedset2 = new SortedSet<string>();

            sortedset2.Add("BCA");

            sortedset2.Add("BBA");

            sortedset2.Add("BTECH");            

            sortedset1.UnionWith(sortedset2);

            Console.WriteLine("After apply the unionwith operation the set is as:");

            foreach (string str in sortedset1)
            {
                Console.WriteLine(str);
            }            
        }
    }
}