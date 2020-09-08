using System;
using System.Collections.Concurrent;

namespace ConcurrentStack
{
    class Program
    {
        static void Main(String[] args)
        {
            int[] elements = { 50, 10, 0 };
            ConcurrentStack<int> stack = new ConcurrentStack<int>(elements);

            Console.WriteLine(string.Join(",", stack.ToArray()));
            stack.Push(2000);

            Console.WriteLine(string.Join(",", stack.ToArray()));

            if (stack.TryPeek(out int resultPeek))
            {
                Console.WriteLine("TryPeek result:" + resultPeek);
            }

            if (stack.TryPop(out int resultPop))
            {
                Console.WriteLine("TryPop result:" + resultPop);
            }

            Console.WriteLine(string.Join(",", stack.ToArray()));
        }
    }
}
