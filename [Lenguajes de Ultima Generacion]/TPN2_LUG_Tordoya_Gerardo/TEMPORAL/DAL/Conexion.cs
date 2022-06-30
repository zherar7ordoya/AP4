using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace DAL
{
    public class Conexion
    {
        private readonly string ConexionTexto = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ADO_en_Capas;Integrated Security=True";
        private readonly SqlConnection ConexionObjeto = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=ADO_en_Capas;Integrated Security=True");

        private SqlTransaction transaccion;
        private SqlCommand comando;

        // con arraylist
        public DataTable Leer(string consulta, Hashtable datos)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador;

            //paso la consulta y el objeto conection en el constructor
            comando = new SqlCommand(consulta, ConexionObjeto)
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                adaptador = new SqlDataAdapter(comando);

                if (datos != null)
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in datos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        comando.Parameters.AddWithValue(dato, datos[dato]);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            adaptador.Fill(tabla);
            return tabla;

        }


        public bool LeerScalar(string consulta, Hashtable datos)
        {
            ConexionObjeto.Open();
            //uso el constructor del objeto Command al instanciar el objeto
            comando = new SqlCommand(consulta, ConexionObjeto)
            {
                CommandType = CommandType.StoredProcedure
            };
            try
            {
                if (datos != null)
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in datos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        comando.Parameters.AddWithValue(dato, datos[dato]);
                    }
                }

                int respuesta = Convert.ToInt32(comando.ExecuteScalar());
                ConexionObjeto.Close();

                if (respuesta > 0) return true;
                else { return false; }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }


        public bool Escribir(string consulta, Hashtable datos)
        {

            if (ConexionObjeto.State == ConnectionState.Closed)
            {
                ConexionObjeto.ConnectionString = ConexionTexto;
                ConexionObjeto.Open();
            }

            try
            {
                transaccion = ConexionObjeto.BeginTransaction();
                //uso el constructor del objeto command
                comando = new SqlCommand(consulta, ConexionObjeto, transaccion)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (datos != null)
                {
                    //si la hashtable no esta vacia, y tiene el dato q busco 
                    foreach (string dato in datos.Keys)
                    {
                        //cargo los parametros que le estoy pasando con la Hash
                        comando.Parameters.AddWithValue(dato, datos[dato]);
                    }
                }

                int respuesta = comando.ExecuteNonQuery();
                transaccion.Commit();
                return true;
            }

            catch (SqlException)
            {
                transaccion.Rollback();
                return false;
            }
            catch (Exception)
            {
                transaccion.Rollback();
                return false;
            }
            finally
            {
                ConexionObjeto.Close();
            }


        }

    }
}
