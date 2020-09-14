using System;
using Newtonsoft.Json;

namespace JsonSerializationProperties
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }        
        public double Salary { get; set; }
        public DateTime date { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { date = new DateTime(1998, 06, 12) };


            string jsonIncludeDefaultValues = JsonConvert.SerializeObject(person, Formatting.Indented);

            Console.WriteLine(jsonIncludeDefaultValues);           

            string jsonIgnoreDefaultValues = JsonConvert.SerializeObject(person, Formatting.Indented, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Ignore
            });        


            Console.WriteLine(jsonIgnoreDefaultValues);
        }
    }
}
