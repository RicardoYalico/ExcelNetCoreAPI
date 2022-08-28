using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelNetCoreAPI.Domain
{
    public class PostgreSQLConfiguration
    {
        public string ConnectionString { get; set; }
        public PostgreSQLConfiguration(string connectionString) => ConnectionString = connectionString;

    }
}
