using NLog;
using System;
using System.IO;

namespace Logger
{
    class Program
    {    

        static void Main(string[] args)
        {
            String filePath = @"E:/Files/text34.txt";
            Divide div = new Divide(filePath);
            div.log("bhaskar");           
            Console.WriteLine("done!");
        }
    }
    public abstract class Logger
    {
        public abstract void log(String msg);
    }
    public class Divide :Logger
    {
        private string filePath;
       
        public Divide(string filePath)
        {
            this.filePath = filePath;
        }

        public override void log(string message)
        {
            try
            {
                int i = 10, j = 0;
                int rem = i / j;
            }
            catch(DivideByZeroException e)
            {
                
                //throw new NotImplementedException();
                using (StreamWriter w = System.IO.File.AppendText(filePath))
                {
                    w.WriteLine("log entry");
                    w.WriteLine("date: " + DateTime.Now.ToShortDateString() + " Time: " + DateTime.Now.ToShortTimeString());
                    w.WriteLine(message);
                    w.WriteLine("----------------------------------");
                    w.WriteLine(e.Message);
                }
            }
        }
    }
}

