using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 5, k = 0, Div;
            try
            {
                int[] i = { 1, 2, 3, 4, 5, 6, 7 };

                Console.WriteLine(i[7]);
              
                Div = j / k;
                Console.WriteLine(Div);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Div = j / k;
                Console.WriteLine(Div);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("done");
        }
    }
}
