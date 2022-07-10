using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Data.SqlClient;
using System.IO;

namespace DataAccess
{
    public class BaseDAO
    {
        public DataProvider DataProvider { get; set; } = null;
        public SqlConnection connection = null;

        public BaseDAO()
        {
            string connectionString = GetConnectionString();
            DataProvider = new DataProvider(connectionString);
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                                    .SetBasePath(Directory.GetCurrentDirectory())
                                    .AddJsonFile("appsettings.json",true,true)
                                    .Build();
            return config["ConnectionString:FStore"];
        }

        public void CloseConnection() => DataProvider.CloseConnection(connection);
    }
}
