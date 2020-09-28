using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveWithSubject
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject<String> obj = new Subject<string>();
            Observable.Interval(TimeSpan.FromSeconds(1))
                .Select(x => "First" + x)
                .Take(7)
                .Subscribe(obj);
            Observable.Interval(TimeSpan.FromSeconds(2))
                .Select(x => "Second" + x)
                .Take(5)
                .Subscribe(obj);
            var subscription = obj.Subscribe(Console.WriteLine);
           
           
            Console.ReadKey();

        }
    }
}
