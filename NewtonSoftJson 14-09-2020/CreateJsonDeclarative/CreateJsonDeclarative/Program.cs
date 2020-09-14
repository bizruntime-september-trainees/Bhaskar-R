using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace CreateJsonDynamically
{
    public class Product
    {
        public string ProductName { get; set; }
        public bool Enabled { get; set; }   
        public Double price { get; set; }
        public int StockCount { get; set; }
        public int StockValue { get; set; }
        public String[] Tags { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic product = new JObject();
            product.ProductName = "Bookings";
            product.Enabled = true;
            product.Price = 4.90m;
            product.StockCount = 9000;
            product.StockValue = 44100;
            product.Tags = new JArray("Real", "OnSale");

            Console.WriteLine(product.ToString());
        }
    }
}
