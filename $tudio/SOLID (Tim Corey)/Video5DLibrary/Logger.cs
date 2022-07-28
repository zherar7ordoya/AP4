using System;

namespace Video5DLibrary
{
    /// <summary>
    /// 
    /// MÓDULO DE BAJO NIVEL
    /// 
    /// LOGGER depende de nadie, es pues, un módulo de bajo nivel.
    /// </summary>
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to Console: {message}");
        }
    }


}
