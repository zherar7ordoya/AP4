using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace RepositoryPattern
{
    public class ProductRepository : IProductRepository
    {
        public bool Delete(Product productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            using IDbConnection db = new SqlConnection(AppConnection.ConnectionString);
            if(db.State==ConnectionState.Closed)
            {
                db.Open();
            }
            return db.Query<Product>("SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products", commandType: CommandType.Text);
        }

        public bool Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
