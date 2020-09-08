using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedSet<string> set = new SortedSet<string>();
        set.Add("a");
        set.Add("z");
        set.Add("x");

        List<string> list = new List<string>();
        list.Add("a");
        list.Add("y");
        
        set.IntersectWith(list);
       
        foreach (string val in set)
        {
            Console.WriteLine(val);
        }
    }
}