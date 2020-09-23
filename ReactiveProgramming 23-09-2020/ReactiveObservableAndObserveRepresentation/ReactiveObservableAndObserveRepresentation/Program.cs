using System;
using System.Reactive.Disposables;

namespace ReactiveObservableAndObserveRepresentation
{
    public class DemoObservable : IObservable<int>
    {
        public IDisposable Subscribe(IObserver<int> observer)
        {
            observer.OnNext(1);
            observer.OnNext(2);
            observer.OnNext(3);
            observer.OnNext(4);
            observer.OnNext(5);
            observer.OnCompleted();
            return Disposable.Empty;
        }
    }
    public class DemoObserver : IObserver<int>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Observable is done sending all the data.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Observer is suspended with an error:{error.Message}" + error.Message);
        }

        public void OnNext(int value)
        {
            Console.WriteLine("observer emiited value :" + value);
        }      

    }
    class Program
    {
        static void Main(string[] args)
        {
            DemoObservable observable = new DemoObservable();
            DemoObserver observer = new DemoObserver();
            var subscribeHandler = observable.Subscribe(observer);            
        }
    }
}
