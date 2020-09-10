using System;
using System.IO;

namespace StreamWriterClass1
{
    class Program
    {
        static void Main(string[] args)
        {           
                FileStream f = new FileStream("e:/Files/output.txt", FileMode.Create);
                StreamWriter s = new StreamWriter(f);

                s.WriteLine("hello c#");
                s.Close();
                f.Close();
                Console.WriteLine("File created successfully...");
            
        }
    }
}
