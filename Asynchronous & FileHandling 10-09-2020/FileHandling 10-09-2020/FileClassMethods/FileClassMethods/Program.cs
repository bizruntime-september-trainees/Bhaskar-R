using System;
using System.IO;
using System.Linq;

namespace FileClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string dummyLines = "This is first line." + Environment.NewLine +
                     "This is second line." + Environment.NewLine +
                     "This is third line.";
           String path = @"E:\DummyFile.txt";
            File.AppendAllLines(path, dummyLines.Split(Environment.NewLine.ToCharArray()).ToList<string>());
            File.AppendAllText(path, "This is File testing");
            File.WriteAllText(path, "This is dummy text");
            bool isFileExists = File.Exists(path);
            Console.WriteLine(isFileExists);
                        
            File.Copy(path, @"E:\Files\text13.txt");
            
            DateTime lastAccessTime = File.GetLastAccessTime(path);
            Console.WriteLine(lastAccessTime);
                 
                        
            File.Move(path, @"E:\Files\text14.txt");
            
            FileStream fs = File.Open(@"E:\Files\text3.txt", FileMode.OpenOrCreate);

            using (StreamReader sr = File.OpenText(@"E:\Files\text11.txt"))
            {
                String s;
                while((s= sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }            
            File.Delete(@"E:\Files\text8.txt");
            File.Delete(@"E:\Files\text9.txt");
            File.Delete(@"E:\Files\text10.txt");
        }
    }
}
