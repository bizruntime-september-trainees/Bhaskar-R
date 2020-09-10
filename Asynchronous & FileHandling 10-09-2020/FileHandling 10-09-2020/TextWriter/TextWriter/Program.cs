using System;
using System.IO;

namespace TextWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Write();
            using (TextReader read = File.OpenText(@"E:/Files/text112.txt"))
            {
                Console.WriteLine(read.ReadToEnd());
            }
        }
        static async void Write()
        {
            using (StreamWriter writer = File.CreateText(@"E:/Files/text112.txt"))
            {
                await writer.WriteLineAsync("First line of example");
                await writer.WriteLineAsync("and second line");
            }
        }

    }
}
