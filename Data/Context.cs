using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Data
{
    public class Context : IContext
    {
        IConfiguration configuration;
        public Context(IConfiguration _configuration)
        {
            configuration = _configuration;
        }

        public IDbConnection GetConnection()
        {
            var connectionString = configuration.GetSection("ConnectionStrings").GetSection("CatalogosConnection").Value;
            var conn = new SqlConnection(connectionString);
            return conn;
        }
    }
}
