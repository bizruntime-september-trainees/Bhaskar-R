using System;
using System.IO;

namespace InnerExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            try
            {
                try
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    for (int j = 0; j < arr.Length; j++)
                    {
                        Console.WriteLine(arr[j]);
                    }
                }

                catch (Exception ex)
                {
                    
                    string filePath = @"E:\new programs\Newfile.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name + ex.Message + ex.StackTrace);
                        sw.Close();
                        Console.WriteLine("There is a problem! Plese try later");
                    }
                    else
                    { 
                        
                        throw new FileNotFoundException(filePath + " Does not Exist", ex);

                    }
                }
            }
            catch (Exception e)
            {
                 Console.WriteLine("Current or Outer Exception = " + e.GetType().Name);
                if (e.InnerException != null)
                {
                    Console.Write("Inner Exception : "+ e.InnerException.GetType().Name);
                  
                }
            }
            
        }
    }
}
