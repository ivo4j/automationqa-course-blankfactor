using System.Data.Common;

namespace App11.Database
{
    public interface IConnectionFactory
    {
        DbConnection CreateConnection();
    }
}
