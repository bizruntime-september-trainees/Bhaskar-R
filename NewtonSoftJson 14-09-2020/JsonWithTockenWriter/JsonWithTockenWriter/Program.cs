using Newtonsoft.Json.Linq;
using System;

namespace JsonWithTockenWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            JTokenWriter writer = new JTokenWriter();
            writer.WriteStartObject();
            writer.WritePropertyName("Type");
            writer.WriteValue("languages");
            writer.WritePropertyName("CodingLanguages");
            writer.WriteStartArray();
            writer.WriteValue(".Net");
            writer.WriteValue("Java");
            writer.WriteValue("C");
            writer.WriteValue("C++");
            writer.WriteValue("Phyton");
            writer.WriteEndArray();
            writer.WriteEndObject();

            JObject obj = (JObject)writer.Token;

            Console.WriteLine(obj.ToString());
        }
    }
}
