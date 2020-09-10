using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace StreamWriterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DirectoryInfo[] eDirs = new DirectoryInfo(@"E:\").GetDirectories();
            
            using (StreamWriter sw = new StreamWriter("E:/Files/text1.txt"))
            {
                foreach (DirectoryInfo dir in eDirs)
                {
                    sw.WriteLine(dir.Name);
                }
            }
            
            string line = "";
            using (StreamReader sr = new StreamReader("E:/Files/text1.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}