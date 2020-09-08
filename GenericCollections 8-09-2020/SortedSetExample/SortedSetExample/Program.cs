using System;
using System.Collections.Generic;

namespace SortedSetExample

{
    class Program

    {
        static void Main(string[] args)

        {            

            SortedSet<string> sortedset = new SortedSet<string>();                  

            sortedset.Add("Sunady");
            sortedset.Add("Monday");
            sortedset.Add("Tuesday");
            sortedset.Add("Wednesday");
            sortedset.Add("Thusday");
            sortedset.Add("Friday");
            sortedset.Add("Saturday");
            SortedSet<int> sortedset1 = new SortedSet<int>();

            sortedset1.Add(1);
            sortedset1.Add(40);
            sortedset1.Add(25);
            sortedset1.Add(10);
            sortedset1.Add(20);            

            Console.WriteLine("The elements in the SortedSet1:");

            Console.WriteLine();

            foreach (int i in sortedset1)
            {
                Console.WriteLine(i);
            }        

            Console.WriteLine("min element in sortedset1:{0}",sortedset1.Min);

            Console.WriteLine("The elements in the SortedSet:");
            Console.WriteLine();
            foreach (string s in sortedset)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("max element in sortedset:{0}", sortedset.Max);
            sortedset.Remove("Monday");

            sortedset.Remove("Tuesday");

            sortedset.Remove("Sunday");

            sortedset.Remove("Saturday");

            Console.WriteLine();


            Console.WriteLine("After removal of the elements from the SortedSet is as:");

            Console.WriteLine();

            foreach (string s in sortedset)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("After removal of the elements from the SortedSet count is{0}:" ,sortedset.Count);

            sortedset1.Remove(1);

            sortedset1.Remove(20);

            sortedset1.Remove(25);

            Console.WriteLine();

            Console.WriteLine("After removal of the elements from the SortedSet1 is as:");

            Console.WriteLine();

            foreach (int s in sortedset1)
            {
                Console.WriteLine(s);
            }
            
            sortedset.Clear();
            Console.WriteLine("After Clear  the elements from the SortedSet count is:{0}",sortedset.Count);

        }

    }
}
