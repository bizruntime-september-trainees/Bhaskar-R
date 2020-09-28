using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace UsingSubjectRX
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject<int> sub = new Subject<int>();

           var dispose= sub.Subscribe(Console.WriteLine);

            sub.OnNext(5);
            sub.OnNext(8);
            dispose.Dispose();
            sub.OnNext(56);
            Console.ReadKey();
        }
    }
}
