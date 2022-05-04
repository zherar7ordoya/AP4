using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Encapsula la funcionalidad que la aplicación necesita para recuperar y
    /// enumerar los productos disponibles en la base de datos. También para
    /// poder ver los productos según la categoría a la que pertenecen. La
    /// información que necesita está en dos tablas de base de datos: la tabla
    /// Catalogo y la tabla Productos. Estas dos tablas están relacionadas a
    /// través del campo ID_Catalogo.
    /// </summary>
    class DataAccessLayerCatalogo
    {
        public DataSet ObtenerInfoProducto()
        {
            DataSet productos;
            string cadena = DataAccessLayerUtilidad.ObtenerConexionSQL("ConexionPSO");

            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                productos = new DataSet("Productos");

                //Obtener Info sobre Categorías
                String categoriaSQL =
                    "SELECT Id_Categoria, Nombre, Descripcion " +
                    "FROM Categorias";
                using (SqlCommand categoriaCMD = new SqlCommand(categoriaSQL, conexion))
                {
                    using (SqlDataAdapter categoriaINFO = new SqlDataAdapter(categoriaCMD))
                    {
                        categoriaINFO.Fill(productos, "Categorias");
                    }
                }

                //Obtener Info sobre Productos
                String productoSQL =
                    "SELECT Id_Producto, Id_Categoria, Nombre, Descripcion, CostoUnitario " +
                    "FROM Productos";
                using (SqlCommand productoCMD = new SqlCommand(productoSQL, conexion))
                {
                    using (SqlDataAdapter productoINFO = new SqlDataAdapter(productoCMD))
                    {
                        productoINFO.Fill(productos, "Productos");
                    }
                }
            }

            //Establecer la relación entre las tablas Producto y Categoria.
            DataRelation relacion = new DataRelation("Categoria_Producto",
                productos.Tables["Categorias"].Columns["Id_Categoria"],
                productos.Tables["Productos"].Columns["Id_Categoria"], false);
            productos.Relations.Add(relacion);
            //TODO: Reconstruir las tablas
            return productos;
        }
    }
}
