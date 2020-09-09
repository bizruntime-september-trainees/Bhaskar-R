using System;
using System.IO;
using System.IO.Enumeration;

namespace BinaryWriterAndReader
{
    class Program
    {
        const String fileName = @"E:\new programs\text1.txt";
        static void Main(string[] args)
        {            
            WriteBinaryFile();
            ReadBinaryFile();
        }
         static void WriteBinaryFile()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {

                writer.Write(12.5);
                writer.Write("this is string data");
                writer.Write(true);
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
            {
                Console.WriteLine("Double Value : " + reader.ReadDouble());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());
            }
        }
    }
}

