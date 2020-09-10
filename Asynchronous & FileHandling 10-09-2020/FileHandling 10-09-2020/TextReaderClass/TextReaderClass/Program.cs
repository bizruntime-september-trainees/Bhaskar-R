using System;
using System.IO;

namespace TextReaderClass
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("e:/Files/text1.txt"))
            {
                Console.WriteLine(tr.ReadLine());
                                
                Console.WriteLine(tr.ReadToEnd());
            }
        }
    }
}
