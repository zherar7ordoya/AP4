using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReactiveExtensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Con Observable (usa 2 clases)
            var evenNumber1 = new EvenNumberObservable();
            var consoleObserver = new ConsoleLogObserver();
            evenNumber1.Subscribe(consoleObserver);

            // Con Subject (usa 1 clase)
            var evenNumber2 = new EvenNumberSubject();
            evenNumber2.Run();
            evenNumber2.Subscribe(Console.WriteLine);

            // ...pero con Observable (no usa ninguna clase)
            Observable.Range(1, 100).Where(x => x % 2 == 0).Subscribe(WriteLine);

            // Con este concepto, podemos usar muchas de las características
            // de LinQ. Por ejemplo, para reproducir el primer output:
            Observable
                .Range(1, 100)
                .Where(x => x % 2 == 0)
                .Select(x => $"Even number {x}")
                .Subscribe(WriteLine);

            WriteLine("THE END");
            ReadKey();
        }
    }
}
