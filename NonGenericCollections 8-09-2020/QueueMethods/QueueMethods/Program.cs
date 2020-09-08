using System;
using System.Collections;

namespace QueueMethods
{
    public class QueueMethods
    {
        public static void Main()
        {

            Queue queue = new Queue();
            queue.Enqueue("Bhaskar");
            queue.Enqueue("student");
            queue.Enqueue("0");
            queue.Enqueue("#");
            Console.WriteLine("\tCount{0}", queue.Count);
            Console.Write("\tValues:");

            foreach (Object obj in queue)
            {
                Console.Write("    {0}", obj);
            }
            Console.WriteLine();
            Console.WriteLine(queue.Peek());
            queue.Dequeue();
            Console.WriteLine("After using Dequeue:");
            foreach (Object obj1 in queue)
            {
                Console.Write("  {0}", obj1);
            }
        }
    }
}
