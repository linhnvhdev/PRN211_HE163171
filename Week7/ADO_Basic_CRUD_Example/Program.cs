using System;
using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ADO_Basic_CRUD_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program test = new Program();
            //test.ConnectDatabase();
            //test.InsertToDatabase();
            test.DataAdapterExample();
        }

        public void DataAdapterExample()
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM [MyStore].[dbo].[Products]",con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    foreach(DataRow dr in dt.Rows)
                    {
                        Console.WriteLine(dr["ProductID"] + " " + dr["ProductName"] + " " + dr[2]);
                    }
                    DataSet ds = new DataSet();
                    adapter.Fill(ds,"student");
                    Console.WriteLine("=======================Dataset=================");
                    foreach(DataRow dr in ds.Tables["student"].Rows)
                    {
                        Console.WriteLine(dr["ProductID"] + " " + dr["ProductName"] + " " + dr[2]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void ConnectDatabase()
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    Console.WriteLine("Connection Established hmmm successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void InsertToDatabase()
        {
            try
            {
                string ConnectionString = "data source=.; database=MyStore; user id=sa; password=Yotsugi123; Encrypt=False";
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();
                    SqlCommand sql = new SqlCommand("SELECT * FROM [MyStore].[dbo].[Products]", con);
                    SqlDataReader sdr = sql.ExecuteReader();
                    while (sdr.Read())
                    {
                        Console.WriteLine(sdr["ProductID"] + " " + sdr.GetString(1));    
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
