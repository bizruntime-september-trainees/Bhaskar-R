using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonFromAnObject
{    public class Vehicle
    {
        public string Type { get; set; }
        public String FuelType { get; set; }
        public IList<string> Examples { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle computer = new Vehicle
            {
                Type = "HeavyVehicle",
                FuelType = "Diesel",
                Examples = new List<string>
                                {
                                    "Bus",
                                    "Truck",
                                    "Van"
                                }
            };

            JObject obj = (JObject)JToken.FromObject(computer);

            Console.WriteLine(obj.ToString());
        }
    }
}
