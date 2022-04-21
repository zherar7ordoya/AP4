using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion_IU
{
    public class ClsProfesional : ClsJugador
    {

        public override int ObtenerPuntaje()
        {
            int puntaje = 0;
            puntaje = 20 * this.GolesRealizados - 4 * this.CantidadRojas - 2 * this.CantidadAmarillas;
            return puntaje;
        }


    }
}
