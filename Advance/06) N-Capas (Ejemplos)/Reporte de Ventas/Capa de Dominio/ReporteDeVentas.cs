using System;
using System.Collections.Generic;
using System.Linq;
using Capa_de_Acceso_a_Datos;
using System.Data;
using System.Globalization;

namespace Capa_de_Dominio
{
    public class ReporteDeVentas
    {
        public DateTime fecha { get; private set; }
        public DateTime desde { get; private set; }
        public DateTime hasta { get; private set; }

        public List<ListadoDeVentas> listado_de_ventas { get; private set; }
        public List<VentasNetasPorPeríodo> ventas_netas_por_periodo { get; private set; }
        public double total_ventas_netas { get; private set; }

        public void CrearReporteDeÓrdenesDeVentas(DateTime desde, DateTime hasta)
        {
            this.fecha = DateTime.Now;
            this.desde = desde;
            this.hasta = hasta;

            var objeto_de_acceso_a_datos = new Objeto_de_Acceso_a_Datos();
            var resultado = objeto_de_acceso_a_datos.ListarÓrdenes(desde, hasta);

            listado_de_ventas = new List<ListadoDeVentas>();

            foreach (DataRow fila in resultado.Rows)
            {
                var modelo_de_ventas = new ListadoDeVentas()
                {
                    Id = Convert.ToInt32(fila[0]),
                    Fecha = Convert.ToDateTime(fila[1]),
                    Cliente = Convert.ToString(fila[2]),
                    Producto = Convert.ToString(fila[3]),
                    Total = Convert.ToDouble(fila[4])
                };
                listado_de_ventas.Add(modelo_de_ventas);
                total_ventas_netas += Convert.ToDouble(fila[4]);
            }

            var ventas_por_fecha = (from venta in listado_de_ventas
                                    group venta by venta.Fecha
                                    into ventas
                                    select new
                                    {
                                        fecha = ventas.Key,
                                        monto = ventas.Sum(item => item.Total)
                                    }).AsEnumerable();

            int días = Convert.ToInt32((hasta - desde).Days);

            if (días <= 7)
            {
                ventas_netas_por_periodo = (from venta in ventas_por_fecha
                                            group venta by venta.fecha.ToString("dd-MM-yy")
                                            into ventas
                                            select new VentasNetasPorPeríodo
                                            {
                                                Período = ventas.Key,
                                                VentasNetas = ventas.Sum(item => item.monto)
                                            }).ToList();
            }
            else if (días <= 30)
            {
                ventas_netas_por_periodo = (from venta in ventas_por_fecha
                                            group venta by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(venta.fecha, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                            into ventas
                                            select new VentasNetasPorPeríodo
                                            {
                                                Período = "Semana " + ventas.Key.ToString(),
                                                VentasNetas = ventas.Sum(item => item.monto)
                                            }).ToList();
            }
            else if (días <= 365)
            {
                ventas_netas_por_periodo = (from venta in ventas_por_fecha
                                            group venta by venta.fecha.ToString("MM-yyyy")
                                            into ventas
                                            select new VentasNetasPorPeríodo
                                            {
                                                Período = ventas.Key,
                                                VentasNetas = ventas.Sum(item => item.monto)
                                            }).ToList();
            }
            else
            {
                ventas_netas_por_periodo = (from venta in ventas_por_fecha
                                            group venta by venta.fecha.ToString("yyyy")
                                            into ventas
                                            select new VentasNetasPorPeríodo
                                            {
                                                Período = ventas.Key,
                                                VentasNetas = ventas.Sum(item => item.monto)
                                            }).ToList();
            }
        }
    }
}
