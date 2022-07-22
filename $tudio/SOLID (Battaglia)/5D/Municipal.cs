using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5D
{
    public class Municipal : Impuesto
    {
        public Municipal(double importe, string partida) : base(importe)
        {
            Partida = partida;
        }
        public string Partida { get; set; }
    }
}
