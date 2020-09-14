using Newtonsoft.Json.Linq;
using System;

namespace ParsingJsonArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = @"[
                              'apple',
                              'orange',
                              'Banana'
                            ]";
            JArray a = JArray.Parse(product);

            Console.WriteLine(a.ToString());


        }
    }
}
