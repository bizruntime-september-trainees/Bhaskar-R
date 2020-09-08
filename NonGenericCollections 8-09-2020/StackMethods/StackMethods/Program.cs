using System;
using System.Collections;

namespace StackMethods
{    
    public class StackMethods
    {
        public static void Main()
        {
            
            Stack myStack = new Stack();
            myStack.Push("Bhaskar");
            myStack.Push("student");
            myStack.Push("0");           
            myStack.Push("#");
            Console.WriteLine("\tCount{0}", myStack.Count);
            Console.Write("\tValues:");

            foreach (Object obj in myStack)
            {
                Console.Write("    {0}", obj);
            }
            Console.WriteLine();
            Console.WriteLine(myStack.Peek());
            myStack.Pop();
            Console.WriteLine("After using pop:");
            foreach (Object obj1 in myStack)
            {
                Console.Write("    {0}", obj1);
            }

        }

      
           
        
    }
}
