using Microsoft.Data.SqlClient;
using Nest;
using System.Data;

namespace ProjectD.Models
{
    public class EmptRepository : EmptRepositoryBase1
    {
        private static readonly object? newEmp;

        public static int Id { get; private set; }
        public static string? Name { get; private set; }
        public static decimal salary { get; private set; }
        public static object? city { get; private set; }

        public static List<Employee>? GetEmployees()
        {
            List<Employee> employeeslist = new List<Employee>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectEmployeecmd = cn.CreateCommand();
                string selectEmployee = "select * from emptable";
                selectEmployeecmd.CommandText = selectEmployee;
                SqlDataReader Employee = selectEmployeecmd.ExecuteReader();
                while (Employee.Read())
                {
                    Employee employee = new Employee();
                    {
                        Id = Employee.GetInt32(0);
                        Name = Employee.GetString(1);
                        salary = Employee.GetDecimal(2);
                        city = Employee.GetString(3);
                    };

                }

            }
            return employeeslist;
        }

        public static int DeleteEmployee(int employeeId)
        {
            return 0;
        }

        public static int UpdateEmployee(Employee modifiedemployee)
        {
            return 0;
        }
    }

    
} 
