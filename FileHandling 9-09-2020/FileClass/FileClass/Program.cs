using System;
using System.IO;

namespace FileClass
{
    class Test
    {
        public static void Main()
        {
            string path = @"E:\Files\Dictionary.txt";
            String path1= @"E:\Files\MyTest.txt";
            if (!File.Exists(path1))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path1))
                {
                    sw.WriteLine("Hi");
                    sw.WriteLine("this");
                    sw.WriteLine("is");
                    sw.WriteLine("visual Studio 2019");
                }
            }
            File.Delete(path1);

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
