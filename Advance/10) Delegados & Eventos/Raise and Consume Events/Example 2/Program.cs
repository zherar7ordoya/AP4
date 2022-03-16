using System;
using static System.Console;

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
        static void Main()
        {
            Counter contador = new Counter(new Random().Next(3, 10));
            contador.LimiteAlcanzadoEventHandler += LimiteAlcanzadoMetodo;

            WriteLine($"\nLÍMITE ASIGNADO: {contador.Limite}\n");

            //TODO Si pulso algo diferente a 'a', el programa termina sin más.
            Console.WriteLine("Press '+' key to increase total");
            while (Console.ReadKey(true).KeyChar == '+')
            {
                Console.WriteLine("Adding 1...");
                contador.Agregar(1);
            }
        }

        static void LimiteAlcanzadoMetodo(object sender, LimiteAlcanzadoEventArgs e)
        {
            WriteLine("The threshold of {0} was reached at {1}", e.Limite, e.Cuando);
            ReadKey();
            Environment.Exit(0);
        }
    }


    class Counter
    {
        public int Limite { get; private set; }
        private int total;
        public event EventHandler<LimiteAlcanzadoEventArgs> LimiteAlcanzadoEventHandler;

        public Counter(int limite) => Limite = limite;

        public void Agregar(int x)
        {
            total += x;
            if (total >= Limite)
            {
                LimiteAlcanzadoEventArgs args = new LimiteAlcanzadoEventArgs();
                args.Limite = Limite;
                args.Cuando = DateTime.Now;
                LimiteAlcanzadoEventHandler?.Invoke(this, args);
            }
        }
    }


    public class LimiteAlcanzadoEventArgs : EventArgs
    {
        public int Limite { get; set; }
        public DateTime Cuando { get; set; }
    }
}
