using System;
using System.Reflection.PortableExecutable;

namespace interface1
{
    interface Mobile
    {
        public void processorType();
        public void romSize();

        public void anroidVersion();
       
    }
    class Redmi:Mobile
    {
        public  void processorType()
        {
            Console.WriteLine("snapdragon-636");
        }
        public  void romSize()
        {
            Console.WriteLine("6GB");
        }
        public void anroidVersion()
        {
            Console.WriteLine("anroid version - 9.0");
        }
    }
    class Realme : Mobile
    {
        public void processorType()
        {
            Console.WriteLine("snapdragon-525");
        }
        public void romSize()
        {
            Console.WriteLine("4GB");
        }
        public void anroidVersion()
        {
            Console.WriteLine("anroid version - 8.0");
        }
    }
    class MobileConfiguarations {
        static void Main(string[] args)
        {
            Mobile specifications;
            specifications = new Redmi();
            specifications.processorType();
            specifications.romSize();
            specifications.anroidVersion();

            specifications = new Realme();
            specifications.processorType();
            specifications.romSize();
            specifications.anroidVersion();

            Console.WriteLine("done!");
        }
    }
    
}
