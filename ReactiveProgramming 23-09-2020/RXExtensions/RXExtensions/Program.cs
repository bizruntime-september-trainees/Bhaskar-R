using System;
using System.Reactive.Linq;

namespace RXExtensions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IObservable<string> obj = Observable.Generate(
                0, //Sets the initial value like for loop    
                _ => true, // infinite loop    
                i => i + 1, //Increment the counter by 1    
                i => new string('#',i), //Append #    
                i => TimeSelector(i)); //delegated this to private method which just calculates time    

            //Subscribe here    
            using (obj.Subscribe(Console.WriteLine))
            {
                Console.WriteLine("Press any key to exit!!!");
                Console.ReadLine();
            }
        }

        //Returns TimeSelector    
        private static TimeSpan TimeSelector(int i)
        {
            return TimeSpan.FromSeconds(i);
        }
    }
}