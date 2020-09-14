using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;
namespace JSONSerializer
{
    class Product
    {
        public DateTime ExpiryDate { set; get; }
        public String Name { set; get; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Product product = new Product() { ExpiryDate = new DateTime(2020, 05, 31),Name = "Sanitizaer" };
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(@"E:\Files\JsonFile.txt"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, product);
                // {"ExpiryDate":new Date(1230375600000),"Price":0}
            }
            Console.WriteLine("Done");
        }
    }
}
