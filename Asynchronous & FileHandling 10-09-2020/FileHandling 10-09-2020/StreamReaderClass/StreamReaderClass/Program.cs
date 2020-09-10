using System;
using System.IO;
using System.Threading.Tasks;

namespace StreamReaderClass
{
    class Example
    {
        static async Task Main(String [] args)
        {
            await ReadAndDisplayFilesAsync();
        }

        static async Task ReadAndDisplayFilesAsync()
        {
            String filename = @"E:/Files/text2.txt";
            Char[] buffer;

            using (var sr = new StreamReader(filename))
            {
                buffer = new Char[(int)sr.BaseStream.Length];
                await sr.ReadAsync(buffer, 0, (int)sr.BaseStream.Length);
               
                Console.WriteLine((int)sr.BaseStream.Length);
            }

            Console.WriteLine(new String(buffer));
        }
    }
}