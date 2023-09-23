using Microsoft.Data.SqlClient;
using System.Data;

namespace ProjectD.Models
{
    public class EmptRepositoryBase
    {

        public static int AddEmployee(Employee newemployee)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmp = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl values( @id,@name,@salary,@city )";
                insertEmp.Parameters.Add("@id", SqlDbType.Int).Value = newEmp.Id;
                insertEmp.Parameters.Add("@name", SqlDbType.NVarChar).Value = newEmp.Name;
                insertEmp.Parameters.Add("@city", SqlDbType.NVarChar).Value = newEmp.City;
                insertEmp.Parameters.Add("@salary", SqlDbType.Decimal).Value = newEmp.Salary;
                insertEmp.CommandText = insertNewEmpQuery;
                query_result = insertEmp.ExecuteNonQuery();
            }
        }
    }
}