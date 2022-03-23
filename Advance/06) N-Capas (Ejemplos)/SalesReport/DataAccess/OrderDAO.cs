using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class OrderDao : ConnectionSQL
    {
        public DataTable GetSalesOrder(DateTime fromDate, DateTime toDate)
        {
            using (var connection = GetConnection())
            {
                connection.Open();

                //try
                //{
                //    connection.Open();
                //}
                //catch (DbEntityValidationException ex)
                //{
                //    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                //    {
                //        foreach (var validationError in entityValidationErrors.ValidationErrors)
                //        {
                //            Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                //        }
                //    }
                //}

                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"
                                            SELECT o.order_id,
                                                   o.order_date,
                                                   c.first_name + ', ' + c.last_name    AS customer,
                                                   products=Stuff((SELECT ' - ' + 'x'
                                                                          + CONVERT(VARCHAR (10), oi2.quantity) + ' '
                                                                          + product_name
                                                                   FROM   Order_Items oi2
                                                                          INNER JOIN products
                                                                                  ON products.product_id = oi2.product_id
                                                                   WHERE  oi2.order_id = oi1.order_id
                                                                   FOR xml path('')), 1, 2, ''),
                                                   Sum(( quantity * price ) - discount) AS total_amount
                                            FROM   orders o
                                                   INNER JOIN customers c
                                                           ON c.customer_id = o.customer_id
                                                   INNER JOIN Order_Items oi1
                                                           ON oi1.order_id = o.order_id
                                            WHERE  o.order_date BETWEEN @fromDate AND @toDate
                                            GROUP  BY o.order_id,
                                                      oi1.order_id,
                                                      o.order_date,
                                                      c.first_name,
                                                      c.last_name
                                            ORDER  BY o.order_id ASC 
                                           ";
                    command.Parameters.Add("@fromDate", SqlDbType.Date).Value = fromDate;
                    command.Parameters.Add("@toDate", SqlDbType.Date).Value = toDate;
                    command.CommandType = CommandType.Text;

                    var reader = command.ExecuteReader();
                    var table = new DataTable();
                    table.Load(reader);
                    reader.Dispose();

                    return table;
                }
            }
        }
    }
}
