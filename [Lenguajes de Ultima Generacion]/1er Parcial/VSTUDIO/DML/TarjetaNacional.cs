﻿using System;
using System.Collections.Generic;
using System.Data;

namespace DML
{
    public class TarjetaNacional : ABS.IGestor<BEL.TarjetaNacional>
    {
        DAL.ConexionSQLServer conexion;


        // *---------------------------------------------=> IMPLEMENTA INTERFAZ

        public BEL.TarjetaNacional Detallar(BEL.TarjetaNacional codigo)
        {
            conexion = new DAL.ConexionSQLServer();
            string consulta = 
                "SELECT " +
                "Codigo, Numero, Vencimiento, Estado, Rubro, TipoNacProv, Provincia, Saldo " +
                "FROM Tarjetas " +
                $"WHERE Codigo = { codigo.Codigo }";
            DataSet datos = conexion.Lectura(consulta);

            if (datos.Tables[0].Rows.Count > 0)
            {
                BEL.TarjetaNacional tarjeta = new BEL.TarjetaNacional();

                foreach (DataRow fila in datos.Tables[0].Rows)
                {
                    tarjeta.Codigo = Convert.ToInt32(fila[0]);
                    tarjeta.Numero = Convert.ToInt32(fila[1]);
                    tarjeta.Vencimiento = Convert.ToDateTime(fila[2]);
                    tarjeta.Estado = fila[3].ToString();
                    tarjeta.Rubro = fila[4].ToString();
                    tarjeta.Pais = fila[5].ToString();
                    tarjeta.Provincia = fila[6].ToString();

                    if (fila[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(fila[7]);
                }
                return tarjeta;
            }
            else
            {
                return null;
            }
        }


        public bool Eliminar(BEL.TarjetaNacional tarjeta)
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
                    $"WHERE CodTarjeta = {tarjeta.Codigo}";
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


        public bool Guardar(BEL.TarjetaNacional tarjeta)
        {
            string consulta;

            if (tarjeta.Codigo == 0)
            {
                consulta = 
                    "INSERT INTO Tarjetas " +
                    "(Numero, Vencimiento, Estado, Rubro, TipoNacProv, Provincia) " +
                    "VALUES(" +
                    $"{ tarjeta.Numero }, " +
                    $"'{ tarjeta.Vencimiento }', " +
                    $"'{ tarjeta.Estado }', " +
                    $"'{ tarjeta.Rubro }', " +
                    $"'{ tarjeta.Pais }', " +
                    $"'{ tarjeta.Provincia }')";
            }
            else
            {
                consulta =
                    "UPDATE Tarjetas " +
                    "SET " +
                    $"Numero = { tarjeta.Numero }, " +
                    $"Vencimiento = '{ tarjeta.Vencimiento }', " +
                    $"Estado = '{ tarjeta.Estado }', " +
                    $"Saldo = { tarjeta.Saldo }, " +
                    $"Rubro = '{ tarjeta.Rubro }', " +
                    $"TipoNacProv = '{ tarjeta.Pais }', " +
                    $"Provincia = '{ tarjeta.Provincia }' " +
                    $"WHERE Codigo = { tarjeta.Codigo }";
            }
            conexion = new DAL.ConexionSQLServer();
            return conexion.Escritura(consulta);
        }


        public List<BEL.TarjetaNacional> Listar()
        {
            List<BEL.TarjetaNacional> ListaTarjetas = new List<BEL.TarjetaNacional>();
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
                    if (fila[5].ToString() == "Argentina")
                    {
                        BEL.TarjetaNacional tarjeta = new BEL.TarjetaNacional
                        {
                            Codigo = Convert.ToInt32(fila[0]),
                            Numero = Convert.ToInt32(fila[1]),
                            Vencimiento = Convert.ToDateTime(fila[2]),
                            Estado = fila[3].ToString(),
                            Rubro = fila[4].ToString(),
                            Pais = fila[5].ToString(),
                            Provincia = fila[6].ToString()
                        };
                        if (fila[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(fila[7]);
                        ListaTarjetas.Add(tarjeta);
                    }
                }
            }

            return ListaTarjetas;
        }


        // *---------------------------------------------------------=> MÉTODOS

        public List<BEL.TarjetaNacional> ListarDisponibles()
        {
            List<BEL.TarjetaNacional> ListaTarjetas = new List<BEL.TarjetaNacional>();
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
                "AND Tarjetas.Provincia IS NOT NULL;";
            datos = conexion.Lectura(consulta);

            if (datos.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow fila in datos.Tables[0].Rows)
                {
                    BEL.TarjetaNacional tarjeta = new BEL.TarjetaNacional
                    {
                        Codigo = Convert.ToInt32(fila[0]),
                        Numero = Convert.ToInt32(fila[1]),
                        Vencimiento = Convert.ToDateTime(fila[2]),
                        Estado = fila[3].ToString(),
                        Rubro = fila[4].ToString(),
                        Pais = fila[5].ToString(),
                        Provincia = fila[6].ToString()
                    };

                    if (fila[7].ToString() != "") tarjeta.Saldo = Convert.ToInt32(fila[7]);
                    ListaTarjetas.Add(tarjeta);
                }
            }
            return ListaTarjetas;
        }
    }
}
