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
                    pubConnection.Open();
                    return (int)pubCommand.ExecuteScalar();
                }
            }
        }


        public List<string> GetAuthorList()
        {
            List<string> nameList = new List<string>();
            using (SqlConnection pubConnection = new SqlConnection(_connString))
            {
                using (SqlCommand authorsCommand = new SqlCommand())
                {
                    authorsCommand.Connection = pubConnection;
                    authorsCommand.CommandText = "Select au_lname from authors";
                    pubConnection.Open();
                    using (SqlDataReader authorDataReader = authorsCommand.ExecuteReader())
                    {
                        while (authorDataReader.Read() == true)
                        {
                            nameList.Add(authorDataReader.GetString(0));
                        }
                        return nameList;
                    }
                }
            }
        }



    }
}
