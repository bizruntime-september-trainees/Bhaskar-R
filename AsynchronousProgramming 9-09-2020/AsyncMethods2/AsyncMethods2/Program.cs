using System;
using System.Threading.Tasks;

namespace AsyncMethods2
{
    class Program
    {
        static void Main(String[] args)
        {
            while (true)
            {
                // Start computation.
                Example();
                // Handle user input.
                string int1 = Console.ReadLine();
                String int2 = Console.ReadLine();

                Console.WriteLine("sum={0} " , int1+int2);
            }
            
        }

        static async void Example()
        {
            // This method runs asynchronously.
            int t = await Task.Run(() => Allocate());
            Console.WriteLine("Compute: " + t);
        }

        static int Allocate()
        {
            // Compute total count of digits in strings.
            int size = 0;
            for (int z = 0; z < 100; z++)
            {
                for (int i = 0; i < 1000000; i++)
                {
                    string value = i.ToString();
                    size += value.Length;
                }
            }
            return size;
        }
    }
}
