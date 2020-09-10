using System;
using System.IO;

namespace FileInfoMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(@"E:\Files\text2.txt");


            FileStream fsToRead = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            FileStream fsToWrite = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            StreamWriter sw = new StreamWriter(fsToWrite);
            sw.WriteLine("Another line from streamwriter");
            sw.Close();
            
            StreamReader sr = new StreamReader(fsToRead);           
            string fileContent = sr.ReadToEnd();
            Console.WriteLine(fileContent);
            sr.Close();
            Console.WriteLine("done");
        }
    }

}

