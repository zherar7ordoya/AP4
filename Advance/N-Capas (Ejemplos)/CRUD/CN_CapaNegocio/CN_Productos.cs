using System;
using System.Data;
using CD_CapaDatos;

namespace CN_CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos productos = new CD_Productos();

        public DataTable CN_MuestraProductos()
        {
            DataTable tabla = productos.CD_MuestraProductos();
            return tabla;
        }

        public void CN_InsertaProducto(
            string nombre,
            string descripcion,
            string marca,
            string precio,
            string stock)
        {
            productos.CD_InsertaProducto(
                nombre,
                descripcion,
                marca,
                Convert.ToDouble(precio),
                Convert.ToInt32(stock));
        }

        public void CN_EditaProducto(
            string nombre,
            string descripcion,
            string marca,
            string precio,
            string stock,
            string id)
        {
            productos.CD_EditaProducto(
                nombre,
                descripcion,
                marca,
                Convert.ToDouble(precio),
                Convert.ToInt32(stock),
                Convert.ToInt32(id));
        }

        public void CN_EliminaProducto(string id)
        {
            productos.CD_EliminaProducto(Convert.ToInt32(id));
        }
    }
}
