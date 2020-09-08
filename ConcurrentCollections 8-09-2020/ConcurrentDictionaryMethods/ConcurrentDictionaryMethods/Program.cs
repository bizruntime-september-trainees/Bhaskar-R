using System;

namespace ConcurrentDictionaryMethods
{
    using System;
    using System.Collections.Concurrent;

    class Program
    {
        static void Main(string[] args)
        {            
            var con = new ConcurrentDictionary<string, int>();
            con.TryAdd("cat", 1);
            con.TryAdd("dog", 2);
            
            con.AddOrUpdate("dog", 5, (k, v) => v + 1);
          
            Console.WriteLine(con["dog"]);
           
            int mouse = con.GetOrAdd("mouse", 4);
            Console.WriteLine(mouse);

            mouse = con.GetOrAdd("mouse", 660);

            Console.WriteLine(mouse);

            con.TryUpdate("cat", 200, 4);
            
            con.TryUpdate("cat", 100, 1);

            Console.WriteLine(con["cat"]);
        }
    }

}
