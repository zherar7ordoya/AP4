﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class Conexion
    {
        #region |||||||||||||||||||||||||||||||||||||||||||| VARIABLES DE CLASE
        private readonly SqlConnection CONEXION_OBJECT = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PedidosDeInsumosDeOficina;Integrated Security=True");
        private readonly string CONEXION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=PedidosDeInsumosDeOficina;Integrated Security=True";
        private SqlTransaction TRANSACCION;
        private SqlCommand COMANDO;
        #endregion

        #region ||||||||||||||||||||||||||||||||||||||||||||||||||||||| MÉTODOS
        /**
         * 1. LEER           --->
         * 2. LEER (ESCALAR) --->
         * 3. ESCRIBIR       ---> CON ROLLBACK
         */
        public DataTable Leer(string consulta, Hashtable htabla)
        {
            DataTable dtabla = new DataTable();
            SqlDataAdapter adaptador;

            COMANDO = new SqlCommand(consulta, CONEXION_OBJECT)
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                adaptador = new SqlDataAdapter(COMANDO);

                if (htabla != null)
                {
                    foreach (string dato in htabla.Keys)
                    {
                        COMANDO.Parameters.AddWithValue(dato, htabla[dato]);
                    }
                }

                adaptador.Fill(dtabla);
                CONEXION_OBJECT.Close();
                return dtabla;
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        //---------------------------------------------------------------------

        public bool LeerEscalar(string consulta, Hashtable htabla)
        {
            CONEXION_OBJECT.Open();
            COMANDO = new SqlCommand(consulta, CONEXION_OBJECT)
            {
                CommandType = CommandType.StoredProcedure
            };

            try
            {
                if (htabla != null)
                {
                    foreach (string dato in htabla.Keys)
                    {
                        COMANDO.Parameters.AddWithValue(dato, htabla[dato]);
                    }
                }

                int respuesta = Convert.ToInt32(COMANDO.ExecuteScalar());
                CONEXION_OBJECT.Close();
                if (respuesta > 0) return true;
                else { return false; }
            }
            catch (SqlException ex) { throw ex; }
            catch (Exception ex) { throw ex; }
        }

        //---------------------------------------------------------------------

        public bool Escribir(string consulta, Hashtable htabla)
        {
            if (CONEXION_OBJECT.State == ConnectionState.Closed)
            {
                CONEXION_OBJECT.ConnectionString = CONEXION_STRING;
                CONEXION_OBJECT.Open();
            }

            try
            {
                TRANSACCION = CONEXION_OBJECT.BeginTransaction();
                COMANDO = new SqlCommand(consulta, CONEXION_OBJECT, TRANSACCION)
                {
                    CommandType = CommandType.StoredProcedure
                };

                if (htabla != null)
                {
                    foreach (string dato in htabla.Keys)
                    {
                        COMANDO.Parameters.AddWithValue(dato, htabla[dato]);
                    }
                }

                int respuesta = COMANDO.ExecuteNonQuery();
                TRANSACCION.Commit();
                return true;
            }

            catch (SqlException)
            {
                TRANSACCION.Rollback();
                return false;
            }
            catch (Exception)
            {
                TRANSACCION.Rollback();
                return false;
            }
            finally { CONEXION_OBJECT.Close(); }
        }
        #endregion
    }
}
