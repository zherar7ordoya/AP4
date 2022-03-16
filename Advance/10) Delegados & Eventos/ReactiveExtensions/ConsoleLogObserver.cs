using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReactiveExtensions
{
    public class ConsoleLogObserver : IObserver<int>
    {
        public void OnCompleted()
        {
            WriteLine("Completed");
        }

        public void OnError(Exception error)
        {
            WriteLine($"Error {error}");
        }

        public void OnNext(int value)
        {
            WriteLine($"Even number {value}");
        }
    }
}
