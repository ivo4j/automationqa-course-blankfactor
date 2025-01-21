using Microsoft.Data.SqlClient;
using System.Data.Common;

namespace App11.Database
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string _connectionString;

        public ConnectionFactory(IConfiguration configuration) =>
            _connectionString = configuration["ConnectionStrings:DefaultConnection"]!;

        public DbConnection CreateConnection() => new SqlConnection(_connectionString);
    }
}
