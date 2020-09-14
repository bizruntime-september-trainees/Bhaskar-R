using Newtonsoft.Json.Linq;
using System;

namespace ParsingJsonObject
{
    class Program
    {
        static void Main(string[] args)
        {
            string json = @"{
                          CPU: 'Intel',
                          Drives: [
                            'DVD read/writer',
                            '500 gigabyte hard drive'
                          ]
                        }";


            JObject obj = JObject.Parse(json);

            Console.WriteLine(obj.ToString());
        }
    }
}
