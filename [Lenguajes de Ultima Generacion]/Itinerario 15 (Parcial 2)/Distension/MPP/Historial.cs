using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP
{
    public class Historial
    {
        public DataSet CargarDatosXML(BE.Historial objeto)
        {
            DataSet dataset = new DataSet();
            dataset.ReadXml(objeto.Archivo);
            return dataset;
        }
    }
}
