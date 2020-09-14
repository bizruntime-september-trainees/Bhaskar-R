using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JSONSerializeDeserialIzeDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, String> points = new Dictionary<int, String>
            {
                { 9001, "James" },
                { 9002, "Jackson" },
                { 9005, "Andrwes" }
            };

            string json = JsonConvert.SerializeObject(points, Formatting.Indented);

            Console.WriteLine(json);
           
            Console.WriteLine("Desrialiation Of dictionary is :");
            Dictionary<int, string> name = JsonConvert.DeserializeObject<Dictionary<int, string>>(json);
            foreach (KeyValuePair<int, string> pair in name)
            {
                Console.WriteLine("{0},{1}", pair.Key, pair.Value);
            }


        }
    }
}
