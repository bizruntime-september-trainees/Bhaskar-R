using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HashSetMethods2
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit"
            };
            HashSet<string> names1 = new HashSet<string> {
                "Rajeev",
                "Akash",
                "Amit",
                "Deepak",
                "Mohit"
            };

            names.Add("Bhaskar");
            foreach(String name in names)
            { 
                Console.WriteLine(name);
            }


            // names1.ExceptWith(names);
            names.IntersectWith(names1);
            names.UnionWith(names1);
            Console.WriteLine("hashset with Exceptwith method :");
            foreach (var name in names1)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}