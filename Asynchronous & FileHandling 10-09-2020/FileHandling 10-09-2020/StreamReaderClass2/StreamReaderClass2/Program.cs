using System;
using System.IO;
using System.Threading.Tasks;

namespace StreamReaderClass2
{
    class Program
    {
        static async Task Main(String []args)
        {
            await ReadFile();
        }

        static async Task ReadFile()
        {
            String result;
            using (StreamReader read = File.OpenText(@"E:/Files/text1.txt"))
            {
                Console.WriteLine("Opened file.");
                result = await read.ReadLineAsync();
                Console.WriteLine("First line contains: " + result);
            }
        }
    }
}