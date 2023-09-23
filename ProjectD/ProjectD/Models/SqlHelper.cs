using Microsoft.Data.SqlClient;

namespace ProjectD.Models
{
    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
        {
            var connstring = @"server=200411LTTP2754\SQLEXPRESS ; database= TestDB ; integrated  security=true; Encrypt=false";
            SqlConnection sqlcn=new SqlConnection(connstring);
            return sqlcn;
        }
    }
}
