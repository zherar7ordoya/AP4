using System.Data;
using System.Data.SqlClient;

namespace CD_CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        private DataTable tabla = new DataTable();
        private SqlCommand comando = new SqlCommand();

        public DataTable CD_MuestraProductos()
        {
            comando.Connection = conexion.AbrirConexion();

            #region ALTERNATIVAS
            comando.CommandText = "SELECT * FROM Productos";
            //comando.CommandText = "MostrarProductos";
            //comando.CommandType = CommandType.StoredProcedure;
            #endregion

            SqlDataReader lector = comando.ExecuteReader();
            tabla.Load(lector);
            conexion.CerrarConexion();
            return tabla;
        }

        public void CD_InsertaProducto(
            string nombre,
            string descripcion,
            string marca,
            double precio,
            int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $"INSERT INTO Productos VALUES(" +
                $"'{nombre}', " +
                $"'{descripcion}', " +
                $"'{marca}', " +
                $"'{precio}', " +
                $"'{stock}')";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void CD_EditaProducto(
            string nombre,
            string descripcion,
            string marca,
            double precio,
            int stock,
            int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $"UPDATE Productos SET " +
                $"Nombre='{nombre}', " +
                $"Descripcion='{descripcion}', " +
                $"Marca='{marca}', " +
                $"Precio='{precio}', " +
                $"Stock='{stock}' " +
                $"WHERE id='{id}'";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void CD_EliminaProducto(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = $"DELETE FROM Productos WHERE id='{id}'";
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
