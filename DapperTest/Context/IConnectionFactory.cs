using System.Data;

namespace DapperTest.Context
{
    public interface IConnectionFactory
    {
        IDbConnection Connection();
    }
}
