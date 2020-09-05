using System;

namespace exceptionhandling
{
    class TryCatch
    {
        static void ProcessString(string s)
        {
            if (s == null)
            {
               throw new ArgumentNullException();
                
            }
        }

        static void Main(string[] args)
        {
            string s = null; 

            try
            {
                ProcessString(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
    }

   
}
