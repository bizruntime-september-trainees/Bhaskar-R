using System;
using System.IO;
using System.Threading.Tasks;

namespace AsyncMethod1
{
    
    class Program
    {
        public static void Main(String[] args)
        {
            Task<int> task = HandleFileAsync();

            Console.WriteLine("Please wait...file is processing... " );      
           
            string name = Console.ReadLine();
            Console.WriteLine("You entered (asynchronous logic): " + name);
            
            task.Wait();
            var x = task.Result;
            Console.WriteLine("Count: " + x);

            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }

        static async Task<int> HandleFileAsync()
        {
            string file = @"E:\new programs\EasyCustomException.txt";            
            Console.WriteLine("HandleFile enter");
            int count = 0;            
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();               
                count += v.Length;
              
                for (int i = 0; i < 10000; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0)
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("HandleFile exit");
            return count;
        }
    }

}
