using System;
using System.IO;

namespace FileExceptionHandling
{
    class Program1
    {
     
        static void Main(string[] args)
        {
            StreamReader read = null;
            try
            {
                read = new StreamReader(@"E:\new programs\file11.txt");
                Console.WriteLine(read.ReadToEnd());
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(read != null)
                {
                    read.Close();
                }
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine("done");
        }
    }
}
