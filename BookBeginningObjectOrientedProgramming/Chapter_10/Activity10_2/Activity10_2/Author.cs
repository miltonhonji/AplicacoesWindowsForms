﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Activity10_2
{
    public class Author
    {
        string _connString = @"Data Source=localData;Initial Catalog = pubs; User ID = servername; Password=*******";

        public DataSet GetData()
        {
            DataSet authorDataSet;

            using (SqlConnection pubConnection = new SqlConnection())
            {
                pubConnection.ConnectionString = _connString;

                using (SqlCommand selectCommand = new SqlCommand())
                {
                    selectCommand.CommandText = "Select au_id, au_lname, au_fname from authors";
                    selectCommand.Connection = pubConnection;

                    using (SqlDataAdapter pubDataAdapter = new SqlDataAdapter())
                    {
                        pubDataAdapter.SelectCommand = selectCommand;
                        authorDataSet = new DataSet();
                        pubDataAdapter.Fill(authorDataSet, "Author");
                    }
                }
                return authorDataSet;
            }
        }

        public void UpdateData(DataSet changedData)
        {
            using (SqlConnection pubConnection = new SqlConnection())
            {
                pubConnection.ConnectionString = _connString;

                using (SqlCommand updateCommand = new SqlCommand())
                {
                    updateCommand.CommandText = "Update authors set au_lname = @au_lname, au_fname = @au_fname Where au_id = @au_id";

                    updateCommand.Parameters.Add("@au_id", SqlDbType.VarChar, 11, "au_id");
                    updateCommand.Parameters.Add("@au_lname", SqlDbType.VarChar, 40, "au_lname");
                    updateCommand.Parameters.Add("@au_fname", SqlDbType.VarChar, 40, "au_fname");

                    updateCommand.Connection = pubConnection;

                    using (SqlDataAdapter pubDataAdapter = new SqlDataAdapter())
                    {
                        pubDataAdapter.UpdateCommand = updateCommand;
                        pubDataAdapter.Update(changedData, "Author");
                    }
                }
            }
        }
    }
}