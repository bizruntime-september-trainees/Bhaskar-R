using System;

namespace abstraction
{
    abstract class vehicle
    {
        public abstract void engineType();
        public abstract void gearType();

        public void direction()
        {
            Console.WriteLine("can move both forward and backward direction");
        }
        public void breakingSystem()
        {
            Console.WriteLine("have Anti-Breaking System");
        }
    }
    class car:vehicle
    {
        public override void engineType()
        {
            Console.WriteLine("car have 4-stroke diesel engine");
        }
        public override void gearType()
        {
            Console.WriteLine("car has both automatic and manual gear System");
        }
    }
    class Truck:vehicle
    {
        public override void engineType()
        {
            Console.WriteLine("truck have 6-stroke diesel engine");
        }
        public override void gearType()
        {
            Console.WriteLine("truck has manual gear System");
        }
    }
    class VehicleConfigurations
    { 
        static void Main(string[] args)
        {
            vehicle v;

            v = new car();
            v.engineType();
            v.gearType();
            v.breakingSystem();
            v.direction();
            v = new Truck();
            v.breakingSystem();
            v.engineType();
            v.direction();
            v.gearType();

            Console.WriteLine("done!");
        }
    }
}
