using System;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace JSONSerializationAndDeserialization
{
    class Product
    {
        public String Name { set; get; }
        public Double Price { set; get; }
        public DateTime ExpiryTime { set; get; }
        public String[] Sizes { set; get; } 
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Product product = new Product { Name = "apple", Price = 10.50, 
                                ExpiryTime = new DateTime(2020, 5, 28),Sizes=new string[] {"small","medium","large"} };

            string output = JsonConvert.SerializeObject(product);
            Console.WriteLine(output);
            Product deserialize = JsonConvert.DeserializeObject<Product>(output);
            Console.WriteLine("Name={0}",deserialize.Name);
            Console.WriteLine("price={0}",deserialize.Price);
            Console.WriteLine("ExpiryDate :{0}",deserialize.ExpiryTime);
            foreach(String sizes in deserialize.Sizes)
            {
                Console.WriteLine(sizes);
            }
        }
    }
}
