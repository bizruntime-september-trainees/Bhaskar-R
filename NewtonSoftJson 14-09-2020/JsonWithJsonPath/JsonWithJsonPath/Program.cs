using Newtonsoft.Json.Linq;
using System;

namespace JsonWithJsonPath
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject o = JObject.Parse(@"{
                              'AutoMobile': [
                                'LightWeight',
                                'HeavyWeight'
                              ],
                              'Manufacturers': [
                                {
                                  'Name': 'Tata',
                                  'Products': [
                                    {
                                      'Name': 'Bus',
                                      'Price': 50000
                                    }
                                  ]
                                },
                                {
                                  'Name': 'Maruthi',
                                  'Products': [
                                    {
                                      'Name': 'car',
                                      'Price': 10000
                                    },
                                    {
                                      'Name': 'Bike',
                                      'Price': 5000
                                    }
                                  ]
                                }
                              ]
                            }");

            string name = (string)o.SelectToken("Manufacturers[0].Name");

            Console.WriteLine(name);          

            decimal productPrice = (decimal)o.SelectToken("Manufacturers[0].Products[0].Price");

            Console.WriteLine(productPrice);

            string productName = (string)o.SelectToken("Manufacturers[1].Products[0].Name");

            Console.WriteLine(productName);
        }
    }
}
