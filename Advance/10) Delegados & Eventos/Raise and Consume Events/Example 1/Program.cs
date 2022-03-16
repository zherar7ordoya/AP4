using System;

namespace Example_1
{
    /// <summary>
    /// The first example shows how to raise and consume an event that doesn't
    /// have data. It contains a class named Counter that has an event named
    /// ThresholdReached. This event is raised when a counter value equals or
    /// exceeds a threshold value. The EventHandler delegate is associated with
    /// the event, because no event data is provided.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Contador conteo = new Contador(new Random().Next(10));
            conteo.EventoLimiteAlcanzado += MetodoLimiteAlcanzado;

            Console.WriteLine("press 'a' key to increase total");
            while (Console.ReadKey(true).KeyChar == 'a')
            {
                Console.WriteLine($"...adding one (limite: {conteo.limite} | total: {conteo.total})");
                conteo.Add(1);
            }
        }

        static void MetodoLimiteAlcanzado(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }


    class Contador
    {
        //private int limite;
        //private int total;

        public int limite;
        public int total;

        public Contador(int pLimite) => limite = pLimite;

        public void Add(int x)
        {
            total += x;
            if (total >= limite) EventoLimiteAlcanzado?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler EventoLimiteAlcanzado;
    }
}
