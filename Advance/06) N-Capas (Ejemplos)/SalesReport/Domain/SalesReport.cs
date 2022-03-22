using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess;
using System.Data;
using System.Globalization;

namespace Domain
{
    public class SalesReport
    {
        // Atributos & Propiedades.--------------------------------------------
        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }

        public List<SalesListing> salesListing { get; private set; }
        public List<NetSalesByPeriod> netSalesByPeriod { get; private set; }
        public double totalNetSales { get; private set; }

        // Métodos.------------------------------------------------------------
        public void CreateSalesOrderReport(DateTime fromDate, DateTime toDate)
        {
            //implement dates
            reportDate = DateTime.Now;
            startDate = fromDate;
            endDate = toDate;

            //create sales listing
            var orderDao = new OrderDao();
            var result = orderDao.GetSalesOrder(fromDate, toDate);

            salesListing = new List<SalesListing>();

            foreach (DataRow rows in result.Rows)
            {
                var salesModel = new SalesListing()
                {
                    orderId = Convert.ToInt32(rows[0]),
                    orderDate = Convert.ToDateTime(rows[1]),
                    customer = Convert.ToString(rows[2]),
                    products = Convert.ToString(rows[3]),
                    totalAmount = Convert.ToDouble(rows[4])
                };
                salesListing.Add(salesModel);

                //calculate total net sales
                totalNetSales += Convert.ToDouble(rows[4]);
            }

            //create net sales by period

            ////create temp list net sales by date
            var listSalesByDate = (from sales in salesListing
                                   group sales by sales.orderDate
                                   into listSales
                                   select new
                                   {
                                       date = listSales.Key,
                                       amount = listSales.Sum(item => item.totalAmount)
                                   }).AsEnumerable();
            
            //*---------------------------------------------------=> AGRUPACIÓN

            ////get number of days
            int totalDays = Convert.ToInt32((toDate - fromDate).Days);

            ////group period by days
            if (totalDays <= 7)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("dd-MMM-yyyy")
                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = listSales.Key,
                                        netSales = listSales.Sum(item => item.amount)
                                    }).ToList();
            }

            ////group period by weeks
            else if (totalDays <= 30)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(sales.date, CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = "Week " + listSales.Key.ToString(),
                                        netSales = listSales.Sum(item => item.amount)
                                    }).ToList();
            }

            ////group period by months
            else if (totalDays <= 365)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("MMM-yyyy")
                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = listSales.Key,
                                        netSales = listSales.Sum(item => item.amount)
                                    }).ToList();
            }

            ////group period by years
            else
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("yyyy")
                                    into listSales
                                    select new NetSalesByPeriod
                                    {
                                        period = listSales.Key,
                                        netSales = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
        }
    }
}
