using System;
using System.Data;
using System.Data.SqlClient;

namespace OfficeSupplyBLL
{
    public class DALCatalogo
    {
        public DataSet GetProductInfo()
        {
            DataSet _dsProducts;
            string connString = DALConector.GetSQLConnection("ConexionConBBDD");
            using (SqlConnection _conn = new SqlConnection(connString))
            {
                _dsProducts = new DataSet("Productos");
                //Get category info
                String strSQL =
                    "SELECT ID_Categoria, Nombre, Descripcion " +
                    "FROM Categorias";
                using (SqlCommand cmdSelCategory = new SqlCommand(strSQL, _conn))
                {
                    using (SqlDataAdapter daCatagory = new SqlDataAdapter(cmdSelCategory))
                    {
                        daCatagory.Fill(_dsProducts, "Categorias");
                    }
                }

                //Get product info
                String strSQL2 =
                    "SELECT ID_Producto, ID_Categoria, Nombre, Descripcion, Precio " +
                    "FROM Productos";
                using (SqlCommand cmdSelProduct = new SqlCommand(strSQL2, _conn))
                {
                    using (SqlDataAdapter daProduct = new SqlDataAdapter(cmdSelProduct))
                    {
                        daProduct.Fill(_dsProducts, "Productos");
                    }
                }
            }
            //Set up the table relation
            DataRelation drCat_Prod = new DataRelation("drCat_Prod",
                _dsProducts.Tables["Categorias"].Columns["ID_Categoria"],
                _dsProducts.Tables["Productos"].Columns["ID_Categoria"], false);
            _dsProducts.Relations.Add(drCat_Prod);
            return _dsProducts;
        }
    }
}