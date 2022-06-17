using Microsoft.Data.SqlClient;
using System.Data.Common;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Data;

namespace DemoDataProviderFactory
{
    internal class Program
    {
        // Get connection string from appsettings.json
        static string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
            var strConnection = config["ConnectionString:MyStoreDB"];
            return strConnection;
        }// End GetConnectionString

        static void ViewProducts()
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            //Get the connection object
            using DbConnection connection = factory.CreateConnection();
            if(connection == null)
            {
                Console.WriteLine($"Unable to create the connection object");
                return;
            }
            connection.ConnectionString = GetConnectionString();
            connection.Open();
            DbCommand command = factory.CreateCommand();
            if(command == null)
            {
                Console.WriteLine($"Unable to create the command object");
                return;
            }
            command.Connection = connection;
            command.CommandText = "Select ProductID, ProductName From Products";
            // Print out data with data reader
            using DbDataReader dbDataReader = command.ExecuteReader();
            Console.WriteLine("******* Product List ********");
            while (dbDataReader.Read())
            {
                Console.WriteLine($"ProductID: {dbDataReader["ProductId"]}, " +
                                    $"ProductName: {dbDataReader["ProductName"]}");

            }
        }//End View Product
        static void Main(string[] args)
        {
            ViewProducts();
            Console.ReadLine();
        }
    }
}
