using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMethod4
{
    class Program
    {
        static void Main()
        {
            Task task = new Task(CallMethod);
            task.Start();
            task.Wait();
            Console.ReadLine();
        }

        static async void CallMethod()
        {
            string filePath = @"E:/Files/text1.txt";
            Task<int> task = ReadFile(filePath);
            FileStream file = new FileStream(@"E:/Files/text112.txt", FileMode.OpenOrCreate);
            StreamWriter writer = new StreamWriter(file);
            writer.Write("this is a new add line");
            StreamReader reader = new StreamReader(@"E:/Files/text2.txt");
            Console.WriteLine(reader.ReadToEnd()); 
            Console.WriteLine(" Other Work 2");
            Console.WriteLine(" Other Work 3");

            int length = await task;
            Console.WriteLine(" Total length: " + length);

            Console.WriteLine(" After work 1");
            Console.WriteLine(" After work 2");
        }

        static async Task<int> ReadFile(string file)
        {
            int length = 0;

            Console.WriteLine(" File reading is stating");
            using (StreamReader reader = new StreamReader(file))
            {
                  
                string s = await reader.ReadToEndAsync();

                length = s.Length;
            }
            Thread.Sleep(5000);
            Console.WriteLine(" File reading is completed");
            return length;
        }
    }
}
