using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos cD_Productos = new CD_Productos();

        public DataTable CN_MuestraProductos()
        {
            DataTable dt = new DataTable();
            dt = cD_Productos.CD_MuestraProductos();
            return dt;
        }
    }
}
