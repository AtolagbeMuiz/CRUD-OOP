using System.Data;
using System.Data.SqlClient;

namespace CRUD_OOP
{
    public class Connection
    {
        SqlConnection sqlConn = new SqlConnection("Server=.;Database=CRUD_OOP;User Id=muiz;Password=oluwadamilare;");

        public SqlConnection ActivateConn()
        {
            if (sqlConn.State == ConnectionState.Closed)
            {
                sqlConn.Open();
            }

            return sqlConn;
        }

    }
}
