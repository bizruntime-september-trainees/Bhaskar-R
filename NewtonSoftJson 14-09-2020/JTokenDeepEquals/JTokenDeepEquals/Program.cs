using Newtonsoft.Json.Linq;
using System;

namespace JTokenDeepEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            JValue s1 = new JValue("Name");
            JValue s2 = new JValue("Nmae");
            JValue s3 = new JValue("Name");

            Console.WriteLine(JToken.DeepEquals(s1, s2));
          
            Console.WriteLine(JToken.DeepEquals(s2, s3));
           
            JObject o1 = new JObject{
                                        { "Integer", 12345 },
                                        { "String", "A string" },
                                        { "Items", new JArray(1, 2) }
                                    };

            JObject o2 = new JObject{
                                        { "Integer", 12345 },
                                        { "String", "A string" },
                                        { "Items", new JArray(1, 2) }
                                    };
            JObject o3 = new JObject{
                                        { "Integer", 12345 },
                                        { "String", "A string" },
                                        { "Items", new JArray(1, 2) }
                                    };

            JObject o4 = new JObject{
                                        { "Integer", 12345 },
                                        { "String", "Name" },
                                        { "Items", new JArray(1, 2) }
                                    };

            Console.WriteLine(JToken.DeepEquals(o1, o2));
            Console.WriteLine(JToken.DeepEquals(o3, o4));

            Console.WriteLine(JToken.DeepEquals(s1, o1["String"]));
            Console.WriteLine(JToken.DeepEquals(s2, o3["String"]));
        }
    }
}
