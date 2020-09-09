using System;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace TaskCreation
{
        public class Example
    {
        public static void Main(String [] args)
        {
            var t = Task<int>.Run(() => {
                
                int max = 1000000;
                int ctr = 0;
                for (ctr = 0; ctr <= max; ctr++)
                {
                    if (ctr == max / 2 )
                    {
                        ctr++;
                        break;
                    }
                }
                return ctr;
            });
            Console.WriteLine("Finished {0:N0} iterations.", t.Result);
        }
    }
}

