using System;

namespace HashSetwithMethods
{
    using System;
    using System.Collections.Generic;

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

            names.IntersectWith(names1);

            Console.WriteLine("using Intersectwithmethod:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.UnionWith(names1);

            Console.WriteLine("using Unionwithmethod:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }           

        }
    }
}


