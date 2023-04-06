using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Activity10_1
{
    class Author
    {
        string _connString = @"Data Source=localData;Initial Catalog = pubs; User ID = servername; Password=*******";

        //Creating a Connection and executing SQL Queries
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

        //Using the DataReader Object to Retrieve Records
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

        //Executing a Stored Procedure Using a Command Object
        public List<string> GetAuthorList(int royalty)
        {
            List<string> nameList = new List<string>();
            using (SqlConnection pubConnection = new SqlConnection(_connString))
            {
                using (SqlCommand authorsCommand = new SqlCommand())
                {
                    authorsCommand.Connection = pubConnection;
                    authorsCommand.CommandType = CommandType.StoredProcedure;
                    authorsCommand.CommandText = "byroyalty";

                    SqlParameter inputParameter = new SqlParameter();

                    inputParameter.ParameterName = "@percentage";
                    inputParameter.Direction = ParameterDirection.Input;
                    inputParameter.SqlDbType = SqlDbType.Int;
                    inputParameter.Value = royalty;

                    authorsCommand.Parameters.Add(inputParameter);
                    pubConnection.Open();

                    using (SqlDataReader authorDataReader = authorsCommand.ExecuteReader())
                    {
                        while(authorDataReader.Read() == true)
                        {
                            nameList.Add(authorDataReader.GetString(0));
                        }
                    }

                    return nameList;
                }
            }
        }
    }
}
