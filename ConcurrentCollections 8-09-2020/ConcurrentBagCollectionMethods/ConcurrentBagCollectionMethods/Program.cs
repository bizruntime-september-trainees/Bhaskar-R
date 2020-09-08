using System;
using System.Collections.Concurrent;

namespace ConcurrentBagCollectionMethods
{    
    class Program
    {
        static void Main(String[] args)
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            bag.Add(1);
            bag.Add(2);
            bag.Add(3);

            int result;
            if (bag.TryPeek(out result))
            {
                Console.WriteLine("TryPeek: {0}", result);
            }

            if (bag.TryTake(out result))
            {
                Console.WriteLine("TryTake: {0}", result);
            }

            if (bag.TryPeek(out result))
            {
                Console.WriteLine("TryPeek: {0}", result);
            }
        }
    }
    class Program1
    {
        static void Main(String[] args)
        {
            
            string[] array = { "Dot", "Net", "Perls" };
            ConcurrentBag<string> bag = new ConcurrentBag<string>(array);

            string value;
            if (bag.TryPeek(out value))
            {
                Console.WriteLine("TryPeek: {0}", value);
            }
            Console.WriteLine("Count:   {0}", bag.Count);
        }
    }
}
