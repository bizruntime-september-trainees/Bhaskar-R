using System;

namespace Conversions
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 345;
            String strng = num1.ToString();
            Console.WriteLine(strng);

            String s = "34";
            int num = int.Parse(s);
            Console.WriteLine(num);

            char[] chars = { 'B', 'i', 'z', 'r', 'u', 'n', 't', 'i', 'm', 'e' };
            String str = new string(chars);
            Console.WriteLine(str);

            String name = "BIZRUNTIME";
            char[] ch = name.ToCharArray();
            foreach(char let in ch)
            {
                Console.Write(let + " " );
            }
            

            
        }
    }
}
