using System;

namespace MulticasteDeligate
{
    public delegate void myTestDel(string Name);
    public delegate void TestMutliCast();
    public delegate int TestMutliCastint();

    class Program
    {
        static void Main(string[] args)
        {           
            myTestDel del = new myTestDel(getName);
            del("Bhaskar");         

            del = new myTestDel(getLocation);
            del("Bangalore");             

            TestMutliCast delmultiCast = new TestMutliCast(Method1);
            delmultiCast += Method2;
            delmultiCast();              

            myTestDel testMulti = new myTestDel(getName);
            testMulti += getLocation;
            testMulti("Abhi");

            // Mutlticast implementation with int return type  

            TestMutliCastint intMulti = new TestMutliCastint(Method3);
            intMulti += Method4;
            int i = intMulti();

            Console.WriteLine("Return Value is " + i);

            Console.ReadLine();
        }

        public static void Method1()
        {
            Console.WriteLine("Delegate 1st method called!!!!");
        }

        public static void Method2()
        {
            Console.WriteLine("Delegate 2nd method called!!!!");
        }

        public static int Method3()
        {
            Console.WriteLine("Delegate 3rd method called!!!!");
            return 3;
        }

        public static int Method4()
        {
            Console.WriteLine("Delegate 4th method called!!!!");
            return 4;
        }

        public static void getName(string name)
        {
            Console.WriteLine("My Name: " + name);
        }

        public static void getLocation(string location)
        {
            Console.WriteLine("My Loc: " + location);
        }
    }
}
