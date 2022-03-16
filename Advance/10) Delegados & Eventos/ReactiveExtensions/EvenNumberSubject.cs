using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveExtensions
{
    public class EvenNumberSubject : IDisposable
    {
        private readonly ReplaySubject<int> subject = new ReplaySubject<int>();
        public readonly List<IDisposable> disposables = new List<IDisposable>();

        public void Dispose()
        {
            subject?.Dispose();
            foreach (var item in disposables) 
            {
                item?.Dispose();
            }
        }

        public void Run()
        {
            Enumerable
                .Range(1, 100)
                .Where(x => x % 2 == 0)
                .ToList()
                .ForEach(x => subject.OnNext(x));
        }

        public void Subscribe(Action<int> action)
        {
            disposables.Add(subject.Subscribe(action));
        }
    }
}
