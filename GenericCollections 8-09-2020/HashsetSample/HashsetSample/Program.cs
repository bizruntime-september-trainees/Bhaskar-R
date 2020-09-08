using System;
using System.Collections.Generic;

namespace HashSetSample
{
    class Program
    {

        static void Main(string[] args)
        {
            HashSet<String> hash = new HashSet<string> { "Bhaskar", "Abhi", "Chaithanya", "jagadeesh", "Bhaskar" };
            foreach (String names in hash)
            {
                Console.WriteLine(names);
            }
        }
    }
}
