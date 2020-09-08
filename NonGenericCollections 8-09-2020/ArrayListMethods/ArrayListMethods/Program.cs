using System;
using System.Collections;

namespace ArrayListMethods
{
    class Program
    { 
        static void Main()
        {            
            ArrayList list = new ArrayList();
            list.Add("One");
            list.Add("Two");
            list.Add("Three");
            list.Add(5);
            list.Add(7);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            ArrayList list2 = new ArrayList();
            list2.Add(10);
            list2.Add(13);
            list.AddRange(list2);
            Console.WriteLine("Adding another arrayList:");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count :{0}",list.Count);
            list.Reverse();
            Console.WriteLine("reversing the  arrayList:");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
             list.Insert(5, "bhaskar");
            list.RemoveAt(6);
            Console.WriteLine(list.IndexOf(5));
        }
    }

}
