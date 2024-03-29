﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Activity10_2
{
    class StoreSales
    {
        string _connString = @"Data Source=localData;Initial Catalog = pubs; User ID = servername; Password=*******";

        public DataSet GetData()
        {
            DataSet storeSalesDataSet;
            storeSalesDataSet = new DataSet();

            using (SqlConnection pubConnection = new SqlConnection(_connString))
            {
                //Fill store table
                using (SqlCommand storeCommand = new SqlCommand())
                {
                    storeCommand.Connection = pubConnection;
                    storeCommand.CommandText = "SELECT [stor_id],[stor_name],[city],[state] FROM [stores]";

                    using (SqlDataAdapter storeDataAdapter = new SqlDataAdapter())
                    {
                        storeDataAdapter.SelectCommand = storeCommand;
                        storeDataAdapter.Fill(storeSalesDataSet, "Stores");
                    }
                    //Fill sales table command
                    using (SqlCommand salesCommand = new SqlCommand())
                    {
                        salesCommand.Connection = pubConnection;
                        salesCommand.CommandText = "SELECT [stor_id],[ord_num],[ord_date],[qty] FROM [sales]";

                        using (SqlDataAdapter salesDataAdapter = new SqlDataAdapter())
                        {
                            salesDataAdapter.SelectCommand = salesCommand;
                            salesDataAdapter.Fill(storeSalesDataSet, "Sales");
                        }
                    }
                    //Create relationship between tables
                    DataColumn Store_StoreIdColumn = storeSalesDataSet.Tables["Stores"].Columns["stor_id"];
                    DataColumn Sales_StoreIdColumn = storeSalesDataSet.Tables["Sales"].Columns["stor_id"];

                    DataRelation StoreSalesRelation = new DataRelation("StoresToSales", Store_StoreIdColumn, Sales_StoreIdColumn);
                    storeSalesDataSet.Relations.Add(StoreSalesRelation);

                    return storeSalesDataSet;
                }
            }
        }
    }
}
