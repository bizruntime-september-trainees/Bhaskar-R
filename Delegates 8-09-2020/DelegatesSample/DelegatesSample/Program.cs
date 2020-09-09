using System;

namespace DelegatesSample
{
    public delegate void myTestDel(string Name);
    class Program
    {
        public static void getName(string name)
        {
            Console.WriteLine("Company Name: " + name);
        }

        public static void getLocation(string location)
        {
            Console.WriteLine("My Loc: " + location);
        }
        static void Main(string[] args)
        {            
            myTestDel del = new myTestDel(getName);
            del("BizRunTime");      

            del = new myTestDel(getLocation);
            del("Bangalore");           
        }        
    }
}
