using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive.Disposables;
using System.Reactive;
using System.Reactive.Linq;

namespace ObservableUsingCreateMethodReactive
{
    class Program
    {
        static void Main(string[] args)
        {
            demo();
            Console.ReadKey();
        }
        static void demo()
        {
            IObservable<int> observable = Observable.Create<int>(observer =>
                  {
                      for (int i = 1; i <= 10; i++)
                      {
                          observer.OnNext(i);

                      }
                      observer.OnCompleted();

                      return Disposable.Empty;
                  });
            IDisposable subscriber = observable.Subscribe(
           
                Console.WriteLine,
                ex => Console.WriteLine(ex.Message),
                () => Console.WriteLine("completed"));
        }
    }    
}
