using System;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace JSONSerializationAndDeserialization
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
           

            string result = JsonConvert.SerializeObject(list);
            Console.WriteLine(result);

            List<Product>items = JsonConvert.DeserializeObject <List<Product>>(result);

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
            }
        }
    }
}
