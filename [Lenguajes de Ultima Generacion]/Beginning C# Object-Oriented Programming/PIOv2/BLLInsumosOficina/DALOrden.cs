using System.Data;
using System.Data.SqlClient;

namespace BLLInsumosOficina
{
    class DALOrden
    {
        public int RealizarPedido(string xmlOrder)
        {
            string connString = DALConector.GetSQLConnection("ConexionConBBDD");
            using (SqlConnection cn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "up_PlaceOrder";
                    SqlParameter inParameter = new SqlParameter
                    {
                        ParameterName = "@xmlOrder",
                        Value = xmlOrder,
                        DbType = DbType.String,
                        Direction = ParameterDirection.Input
                    };
                    cmd.Parameters.Add(inParameter);
                    SqlParameter ReturnParameter = new SqlParameter
                    {
                        ParameterName = "@OrderID",
                        Direction = ParameterDirection.ReturnValue
                    };
                    cmd.Parameters.Add(ReturnParameter);
                    int intOrderNo;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    intOrderNo = (int)cmd.Parameters["@OrderID"].Value;
                    return intOrderNo;
                }
            }
        }
    }
}