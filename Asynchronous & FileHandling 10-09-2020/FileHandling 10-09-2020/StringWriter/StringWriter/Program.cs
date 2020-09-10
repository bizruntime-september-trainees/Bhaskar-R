using System;
using System.Text;
using System.IO;

namespace StringWriterClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, Welcome to the javatpoint \n" +
                "It is nice site. \n" +
                "It provides technical tutorials";
           
            StringBuilder sb = new StringBuilder();

            StringWriter writer = new StringWriter(sb);            
            writer.WriteLine(text);

            writer.Flush();             
            writer.Close();
            
            StringReader reader = new StringReader(sb.ToString());
            
            while (reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }
        }
    }
}
