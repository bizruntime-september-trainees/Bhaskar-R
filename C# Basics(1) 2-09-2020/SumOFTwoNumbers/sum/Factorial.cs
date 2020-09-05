using System;
using System.Collections.Generic;
using System.Text;

namespace sum
{
    class Factorial
    {
        int fact = 1;
         public int factorial(int num)
        {
            for(int i=1;i<=num;i++)
            {
                fact = fact * num;
            }
            
            return fact;
        }
        public static void main(String [] args)
        {
            Factorial f = new Factorial();
           int total =  f.factorial(5);
            Console.WriteLine(total);
        }
    }
}
