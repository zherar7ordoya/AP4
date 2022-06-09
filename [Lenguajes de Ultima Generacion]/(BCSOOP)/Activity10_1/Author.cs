using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Activity10_1
{
    public class Author
    {
        readonly string _connString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
            Initial Catalog=pubs;
            Integrated Security=True";



        public int CountAuthors()
        {
            using (SqlConnection pubConnection = new SqlConnection(_connString))
            {
                using (SqlCommand pubCommand = new SqlCommand())
                {
                    pubCommand.Connection = pubConnection;
                    pubCommand.CommandText = "Select Count(au_id) from authors";

                    try
                    {
                        pubConnection.Open();
                    }
                    catch (SqlException ex) { throw ex; }
                    catch (Exception ex) { throw ex; }
                    finally { pubConnection.Dispose(); }

                    return (int)pubCommand.ExecuteScalar();
                }
            }
        }


        public List<string> GetAuthorList(int royalty)
        {
            List<string> nameList = new List<string>();

            SqlConnection pubConnection = new SqlConnection(_connString);

            SqlCommand authorsCommand = new SqlCommand
            {
                Connection = pubConnection,
                CommandType = CommandType.StoredProcedure,
                CommandText = "byroyalty"
            };

            SqlParameter inputParameter = new SqlParameter
            {
                ParameterName = "@percentage",
                Direction = ParameterDirection.Input,
                SqlDbType = SqlDbType.Int,
                Value = royalty
            };

            authorsCommand.Parameters.Add(inputParameter);

            pubConnection.Open();

            SqlDataReader authorDataReader = authorsCommand.ExecuteReader();

            while (authorDataReader.Read() == true)
            {
                nameList.Add(authorDataReader.GetString(0));
            }

            pubConnection.Close();
            return nameList;
        }



    }
}
