using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3__L_
{
    class Noticiero : Principal
    {
        public Noticiero(string mensaje) : base(mensaje) { }

        public override void Muestra()
        {
            Console.WriteLine("Desde noticiero: {0}", mensaje);
        }
    }
}
