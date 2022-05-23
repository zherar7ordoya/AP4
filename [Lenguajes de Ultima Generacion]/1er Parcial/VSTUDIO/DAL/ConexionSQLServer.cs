using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Console;

namespace DAL
{
    public class ConexionSQLServer
    {
        private readonly SqlConnection conexion = 
            new SqlConnection(ConfigurationManager
            .ConnectionStrings["CadenaConexion"].ToString());


        public ConexionSQLServer()
        {
            //conexion.Open();
            //if (conexion.State == ConnectionState.Open)
            //{
            //    WriteLine("Conexión a la base de datos establecida correctamente.");
            //    ReadKey();
            //}
            //else
            //{
            //    WriteLine("No se pudo establecer conexión a la base de datos.");
            //    ReadKey();
            //}
            //conexion.Close();
        }


        /// <summary>
        /// Para consultas SQL que retornan registros.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public DataSet Lectura(string consulta)
        {
            DataSet datos = new DataSet();

            try
            {
                SqlDataAdapter adaptador = 
                    new SqlDataAdapter(
                        consulta,
                        conexion);
                adaptador.Fill(datos);
            }
            catch (SqlException ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
            finally
            {
                conexion.Close();
            }

            return datos;
        }


        /// <summary>
        /// Para consultas SQL que no retornan nada.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public bool Escritura(string consulta)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = consulta,
                Connection = conexion
            };

            try
            {
                int respuesta = comando.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                throw ex;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }


        /// <summary>
        /// Consulta SQL que retorna un escalar.
        /// </summary>
        /// <param name="consulta"></param>
        /// <returns></returns>
        public bool Conteo(string consulta)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand(consulta, conexion);
            comando.CommandType = CommandType.Text;

            try
            {
                int respuesta = Convert.ToInt32(comando.ExecuteScalar());
                if (respuesta > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                throw ex;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
