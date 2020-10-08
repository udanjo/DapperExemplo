
using System.Data;
using System.Data.SqlClient;

namespace DapperTest.Context
{
    public class dbConnection : IConnectionFactory
    {
        public IDbConnection Connection() 
            => new SqlConnection(@"Server=tcp:myfinanceju.database.windows.net,1433;Initial Catalog=MyFinance;Persist Security Info=False;User ID=udanjo;Password=udsp@2019;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    }
}
