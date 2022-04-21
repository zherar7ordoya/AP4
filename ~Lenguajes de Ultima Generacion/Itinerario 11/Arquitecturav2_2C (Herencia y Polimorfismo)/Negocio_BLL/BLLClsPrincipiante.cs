using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio_BLL
{
   public class BLLClsPrincipiante: BLLClsJugador
    {
        public bool Rapado { get; set; }
        public override int ObtenerPuntaje()
        {
            int puntaje = 0;
            puntaje = 10 * this.GolesRealizados - 2 * this.CantidadRojas - 2 * this.CantidadAmarillas;
            return puntaje;
        }
    }
}
