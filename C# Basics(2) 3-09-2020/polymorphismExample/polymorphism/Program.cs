using System;

namespace polymorphism
{
    class Animals
    {
        public virtual void food()
        {
            Console.WriteLine("eating food");
        }
    }
    class Tiger : Animals

    {
        public override void food()
        {
            Console.WriteLine("Tiger eats meat");
        }
    }
    class Goat : Animals
    {
        public override void food()
        {
            Console.WriteLine("goat eats plants");
        }
    }
    class Humans : Animals
    {
        public override void food()
        {
            Console.WriteLine(" humans are eats plants and meat");
        }
    }
    class Polymorphism
    {
        static void Main(string[] args)
        {
            Animals animal;
            animal = new Tiger();
            animal.food();
            animal = new Goat();
            animal.food();
            animal = new Humans();
            animal.food();

            Console.WriteLine("done!");
        }
    }
}


