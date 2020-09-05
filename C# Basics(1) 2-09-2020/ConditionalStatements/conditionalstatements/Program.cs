using System;

namespace conditionalstatements
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0)            
                Console.WriteLine("Given number is Even");

            else
                Console.WriteLine("Given number is odd");
        }
    }

    class MaxNumb
    {
        static void main(String[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a > b) && (a > c))
            {
                Console.WriteLine("a is a maxNumber");
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("b is a maxNumber");
            }
            else
            {
                Console.WriteLine("c is a maxNumber");
            }

        }

    }
}
