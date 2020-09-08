using System;
using System.Collections.Concurrent;

namespace ConcurrentQueue
{
    class Program
    {
        static void Main(String[] args)
        {          
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            
            Console.WriteLine(string.Join(",", queue.ToArray()));

            if (queue.TryPeek(out int resultPeek))
            {
                Console.WriteLine("TryPeek result:" + resultPeek);
            }
            
            if (queue.TryDequeue(out int resultDequeue))
            {
                Console.WriteLine("TryDeque result:" + resultDequeue);
            }            
            Console.WriteLine(string.Join(",", queue.ToArray()));
        }
    }
}

