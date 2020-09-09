using System;
using System.IO;
namespace DictionaryInfoClass
{
    class Program
    {
        static void Main(string[] args)
        {              
            DirectoryInfo directory = new DirectoryInfo(@"E:\Files\textfiles");
            try
            {                
                if (directory.Exists)
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }                  
                directory.Create();
                Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }
        }
    }
}