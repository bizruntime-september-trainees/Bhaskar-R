using Newtonsoft.Json.Linq;
using System;
using System.Linq;

namespace QueryJsonWithJsonPathAndLinq
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

            string[] Vehicletype = o.SelectToken("AutoMobile").Select(s => (string)s).ToArray();

            Console.WriteLine(string.Join(", ", Vehicletype));
           

            string[] firstProductNames = o["Manufacturers"].Select(m => (string)m.SelectToken("Products[1].Name"))
                .Where(n => n != null).ToArray();

            Console.WriteLine(string.Join(", ", firstProductNames));
           

            decimal totalPrice = o["Manufacturers"].Sum(m => (decimal)m.SelectToken("Products[0].Price"));

            Console.WriteLine(totalPrice);
        }
    }
}
