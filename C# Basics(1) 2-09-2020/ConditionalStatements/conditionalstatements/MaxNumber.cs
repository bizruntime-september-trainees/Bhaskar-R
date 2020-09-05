using System;
using System.Collections.Generic;
using System.Text;

namespace conditionalstatements
{
    class MaxNumber
    {
        static void main(String [] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if ((a>b) && (a>c))
            {
                Console.WriteLine("a is a maxNumber");
            }
            else if((b>a) && (b>c))
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

