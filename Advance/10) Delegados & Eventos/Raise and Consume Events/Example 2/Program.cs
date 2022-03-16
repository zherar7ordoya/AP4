using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ÉSTE SERÍA EL EJEMPLO MÁS FORMAL, MÁS COMPLETO.

namespace Example_2
{
    /// <summary>
    /// The next example shows how to raise and consume an event that provides
    /// data. The EventHandler<TEventArgs> delegate is associated with the
    /// event, and an instance of a custom event data object is provided.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Counter c = new Counter(new Random().Next(10));
            c.ThresholdReached += c_ThresholdReached;


            //TODO Si pulso algo diferente a 'a', el programa termina sin más.
            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine("adding one");
                c.Add(1);
            }
        }

        static void c_ThresholdReached(object sender, ThresholdReachedEventArgs e)
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
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;

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
            EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
            if (handler != null) handler(this, e);
        }
    }


    public class ThresholdReachedEventArgs : EventArgs
    {
        public int Threshold { get; set; }
        public DateTime TimeReached { get; set; }
    }
}
