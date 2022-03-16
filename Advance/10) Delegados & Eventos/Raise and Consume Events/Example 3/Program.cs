using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    /// <summary>
    /// The next example shows how to declare a delegate for an event. The
    /// delegate is named ThresholdReachedEventHandler. This is just an
    /// illustration. Typically, you do not have to declare a delegate for an
    /// event, because you can use either the EventHandler or the
    /// EventHandler<TEventArgs> delegate. You should declare a delegate only in
    /// rare scenarios, such as making your class available to legacy code that
    /// cannot use generics.
    /// </summary>
    
    public delegate void ThresholdReachedEventHandler(Object sender, ThresholdReachedEventArgs e);

    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        static void c_ThresholdReached(Object sender, ThresholdReachedEventArgs e)
        {
            Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threshold, e.TimeReached);
            Console.ReadKey();
            Environment.Exit(0);
        }
    }


    class Counter
    {
        private int threshold;
        private int total;

        public event ThresholdReachedEventHandler ThresholdReached;

        public Counter(int passedThreshold) => threshold = passedThreshold;

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThresholdReached(args);
            }
        }

        protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
        {
            ThresholdReachedEventHandler handler = ThresholdReached;
            if (handler != null) handler(this, e);
        }
    }


    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
