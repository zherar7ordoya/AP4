using System;
using System.Collections.Generic;
using System.Data;

namespace DML
{
    public class TarjetaInternacional : ABS.IGestor<BEL.TarjetaInternacional>
    {
        DAL.ConexionSQLServer conexion;


        #region IMPLEMENTA INTERFAZ.-------------------------------------------

        public BEL.TarjetaInternacional Detallar(BEL.TarjetaInternacional codigo)
        {
            conexion = new DAL.ConexionSQLServer();
            string consulta =
                "SELECT " +
                "Codigo, Numero, Vencimiento, Estado, Rubro, TipoNacProv, Saldo " +
                "FROM Tarjetas " +
                $"WHERE Codigo = { codigo.Codigo }";
            DataSet datos = conexion.Lectura(consulta);

            if (datos.Tables[0].Rows.Count > 0)
            {
                BEL.TarjetaInternacional tarjeta = new BEL.TarjetaInternacional();

                foreach (DataRow fila in datos.Tables[0].Rows)
                {
                    tarjeta.Codigo = Convert.ToInt32(fila[0]);
                    tarjeta.Numero = Convert.ToInt32(fila[1]);
                    tarjeta.Vencimiento = Convert.ToDateTime(fila[2]);
                    tarjeta.Estado = fila[3].ToString();
                    tarjeta.Rubro = fila[4].ToString();
                    tarjeta.Pais = fila[5].ToString();

                    if (fila[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(fila[7]);
                }
                return tarjeta;
            }
            else
            {
                return null;
            }
        }


        public bool Eliminar(BEL.TarjetaInternacional tarjeta)
        {
            conexion = new DAL.ConexionSQLServer();

            string consulta =
                "SELECT COUNT(CodTarjeta) " +
                "FROM Cliente_Tarjeta " +
                $"WHERE CodTarjeta = { tarjeta.Codigo }";
            bool bandera = conexion.Conteo(consulta);

            if (bandera)
            {
                consulta =
                    "DELETE FROM Cliente_Tarjeta " +
                    $"WHERE CodTarjeta = { tarjeta.Codigo }";
                conexion.Escritura(consulta);

                consulta =
                    "UPDATE Clientes " +
                    "SET CodTarjeta = 'NULL' " +
                    $"WHERE Codigo = { tarjeta.Codigo }";
                conexion.Escritura(consulta);
            }

            consulta = 
                "DELETE FROM Tarjetas " +
                $"WHERE Codigo = { tarjeta.Codigo }";
            return conexion.Escritura(consulta);
        }


        public bool Guardar(BEL.TarjetaInternacional giftcard)
        {
            string consulta;
            if (giftcard.Codigo == 0)
            {
                consulta =
                    "INSERT INTO " +
                    "Tarjetas(Numero, Vencimiento, Estado, Rubro, TipoNacProv) " +
                    "VALUES(" +
                    $"{ giftcard.Numero }, " +
                    $"'{ giftcard.Vencimiento }', " +
                    $"'{ giftcard.Estado }', " +
                    $"'{ giftcard.Rubro }', " +
                    $"'{ giftcard.Pais }')";
            }
            else
            {
                consulta = 
                    "UPDATE Tarjetas " +
                    "SET " +
                    $"Numero = { giftcard.Numero }, " +
                    $"Vencimiento = '{ giftcard.Vencimiento }', " +
                    $"Estado = '{ giftcard.Estado }', " +
                    $"Rubro = '{ giftcard.Rubro }', " +
                    $"Saldo = { giftcard.Saldo }, " +
                    $"TipoNacProv = '{ giftcard.Pais }' " +
                    $"WHERE Codigo = { giftcard.Codigo }";
            }
            conexion = new DAL.ConexionSQLServer();
            return conexion.Escritura(consulta);
        }


        public List<BEL.TarjetaInternacional> Listar()
        {
            List<BEL.TarjetaInternacional> ListaTarjetas = new List<BEL.TarjetaInternacional>();
            DataSet datos;
            conexion = new DAL.ConexionSQLServer();
            string consulta =
                "SELECT " +
                "Codigo, Numero, Vencimiento, Estado, Rubro, TipoNacProv, Provincia, Saldo " +
                "FROM Tarjetas";
            datos = conexion.Lectura(consulta);

            if (datos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Tables[0].Rows)
                {
                    if (fila[5].ToString() != "Argentina")
                    {
                        BEL.TarjetaInternacional tarjeta = new BEL.TarjetaInternacional
                        {
                            Codigo = Convert.ToInt32(fila[0]),
                            Numero = Convert.ToInt32(fila[1]),
                            Vencimiento = Convert.ToDateTime(fila[2]),
                            Estado = fila[3].ToString(),
                            Rubro = fila[4].ToString(),
                            Pais = fila[5].ToString()
                        };

                        if (fila[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(fila[7]);
                        ListaTarjetas.Add(tarjeta);
                    }
                }
            }

            return ListaTarjetas;
        }

        #endregion


        // *---------------------------------------------------------=> MÉTODOS

        public List<BEL.TarjetaInternacional> ListarDisponibles()
        {
            List<BEL.TarjetaInternacional> ListaTarjetas = new List<BEL.TarjetaInternacional>();
            DataSet datos;
            conexion = new DAL.ConexionSQLServer();
            string consulta =
                "SELECT " +
                "Codigo, Numero, Vencimiento, Estado, Rubro, TipoNacProv, Provincia, Saldo " +
                "FROM Tarjetas " +
                "FULL OUTER JOIN Cliente_Tarjeta " +
                "ON Tarjetas.Codigo = Cliente_Tarjeta.CodTarjeta " +
                "WHERE Tarjetas.Codigo IS NULL " +
                "OR Cliente_Tarjeta.CodTarjeta IS NULL " +
                "AND Tarjetas.Provincia IS NULL;";
            datos = conexion.Lectura(consulta);

            if (datos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Tables[0].Rows)
                {
                    BEL.TarjetaInternacional tarjeta = new BEL.TarjetaInternacional
                    {
                        Codigo = Convert.ToInt32(fila[0]),
                        Numero = Convert.ToInt32(fila[1]),
                        Vencimiento = Convert.ToDateTime(fila[2]),
                        Estado = fila[3].ToString(),
                        Rubro = fila[4].ToString(),
                        Pais = fila[5].ToString()
                    };

                    if (fila[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(fila[7]);
                    ListaTarjetas.Add(tarjeta);
                }
            }

            return ListaTarjetas;
        }
    }
}
