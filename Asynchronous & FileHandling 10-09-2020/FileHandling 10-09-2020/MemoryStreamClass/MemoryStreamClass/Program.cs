using System;
using System.IO;

using System.Text;
namespace MemoryStreamClass
{
    class Program
    {
        static void Main(String[] args)
        {
            
            byte[] file = File.ReadAllBytes("D:/Bali/Ooty/IMG_3407.jpg");
           
            using (MemoryStream memory = new MemoryStream(file))
            {
               
                using (BinaryReader reader = new BinaryReader(memory))
                {                   
                    for (int i = 0; i < file.Length/2; i++)
                    {
                        byte result = reader.ReadByte();
                        Console.WriteLine(result);
                    }
                }
            }
        }
    }
}
