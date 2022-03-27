using System;
using System.Data;
using System.Data.SqlClient;


namespace Capa_de_Acceso_a_Datos
{
    public class Objeto_de_Acceso_a_Datos : Conexión
    {
        public DataTable ListarÓrdenes(DateTime desde, DateTime hasta)
        {
            using (var conexión = Conectar())
            {
                conexión.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexión;
                    comando.CommandText = @"ListarÓrdenes";
                    comando.Parameters.AddWithValue("@desde", desde);
                    comando.Parameters.AddWithValue("@hasta", hasta);
                    comando.CommandType = CommandType.StoredProcedure;

                    var lector = comando.ExecuteReader();
                    var tabla = new DataTable();
                    tabla.Load(lector);
                    lector.Dispose();

                    return tabla;
                }
            }
        }
    }
}
