using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace SerialIzingJSONFileTOFile
{
    class Product
    {
        public String Name { set; get; }
        public Double Price { set; get; }

    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>() {
                        new Product(){Name="apple",Price = 10.90},
                        new Product(){Name = "Banana",Price=8.40},
                        new Product(){Name="custardApple",Price=12.50},
                        new Product(){Name="Orange",Price=10.20}
                        };

            File.WriteAllText(@"E:\Files\Json2.json",JsonConvert.SerializeObject(list));
            using (StreamWriter file = File.CreateText(@"E:\Files\Json2.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, list);
            }
        }
    }
}


