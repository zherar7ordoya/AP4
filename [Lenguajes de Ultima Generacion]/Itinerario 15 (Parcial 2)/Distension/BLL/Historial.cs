using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Historial
    {
        MPP.Historial HISTORIAL;

        public Historial()
        {
            HISTORIAL = new MPP.Historial();
        }

        public DataSet CargarDatosXML(BE.Historial objeto)
        {
            return HISTORIAL.CargarDatosXML(objeto);
        }
    }
}
