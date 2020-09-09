using System;
using System.IO;

namespace DictionaryClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"E:\newprograms";
            string archiveDirectory = @"E:\Files";

            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt");

                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    Directory.Move(currentFile, Path.Combine(archiveDirectory, fileName));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
