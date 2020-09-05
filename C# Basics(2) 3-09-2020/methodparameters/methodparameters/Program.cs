using System;

namespace methodparameters
{
    class Parameter
    {       
        static void Main(string[] args)
        {
            int j = 50;
            method1(j);
            Console.WriteLine("valueparameter" + j);
            method2(ref j);
            Console.WriteLine("refParameter"+ j);
            int sum, total;
            method3(10, 15, out sum, out total);
            Console.WriteLine($"sum = {sum} && product = {total}");
        }
       public static void method1(int j)
        {
             j = 101;
            Console.WriteLine(j);
        }
    
        public static void method2(ref int k)
        {
            k = 2001;
            Console.WriteLine(k);
        }
        public static void method3(int l,int m,out int sum,out int product)
        {
            sum = l + m;
            product = l * m;         
            
        }
    }
}
