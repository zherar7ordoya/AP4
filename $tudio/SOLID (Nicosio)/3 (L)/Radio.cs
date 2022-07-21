using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__L_
{
    class Radio : Principal
    {
        public Radio(string mensaje) : base(mensaje) { }

        public override void Muestra()
        {
            Console.WriteLine("Desde radio: {0}", mensaje);
        }
    }
}
