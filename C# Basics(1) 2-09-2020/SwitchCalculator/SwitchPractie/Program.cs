using System;

namespace SwitchPractie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("choose the Number form 1 to 5.\n 1 - add \n 2- substarct \n 3-multiply \n 4- division \n " +
                "5-remainder ");

            int num = int.Parse(Console.ReadLine());

            switch (num)
            {

                case 1:
                    Console.WriteLine($"addition of {a} and {b} is {a + b}"); break;
                case 2:
                    Console.WriteLine($"substraction of {a} and {b} is {a - b}"); break;
                case 3:
                    Console.WriteLine($"multiplication of {a} and {b} is {a * b}"); break;
                case 4:
                    Console.WriteLine($"division of {a} and {b} is {a / b}"); break;
                case 5:
                    Console.WriteLine($"remainder of {a} and {b} is {a % b}"); break;
                default:
                    Console.WriteLine("choose correct option");break;
            }        

            Console.WriteLine("done");
        }
    }
}
