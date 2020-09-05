using System;

namespace CustomException
{
    class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base() { }
        public InvalidAgeException(string msg) : base(msg) { }

    }
    class Person
    {
        private int age;
        public int Age
        {
            set
            {
                if (value >= 19)
                    age = value;
                else
                {
                    InvalidAgeException Obj = new InvalidAgeException("you are not eligible to vote");
                    throw Obj;
                }
            }
            get
            {
                return age;
            }
        }
    }
    class Test
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("Enter the age : ");
            try
            {
                string ageInput = Console.ReadLine();

                person.Age = int.Parse(ageInput);
                Console.WriteLine("you are eligible for vote");
            }
            catch (InvalidAgeException expObj)
            {
                Console.WriteLine(expObj.Message);
            }

        }
    }
}
