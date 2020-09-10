using System;
using System.Threading.Tasks;
namespace TaskCreation1
{
    public class Example
    {
            public static async Task Main()
            {
                await Task.Run(() => {                    
                                 int ctr = 0;
                                 for (ctr = 0; ctr <= 1000000; ctr++)
                                 {
                                     Console.WriteLine("Finished {0} loop iterations",ctr);
                                 }
                              });
            }
    }
}
