using System;
using System.Collections.Generic;
using System.Text;

namespace sum
{
    class SwapNum
    {
       
        public static void main(string [] args)
        {
            int num1 = 5, num2 = 10;
            int t = num1;
            num1 = num2;
            num2 = t;
            Console.WriteLine(num1 +  num2);

        }
    }
}
