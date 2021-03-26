using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeInfoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeInfo : IEmployeeInfo
    {
       public List<EmployeeData> getEmployees()  
        {
            string path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            List<EmployeeData> employees = new List<EmployeeData>();
            string connectionString = @"data source=(LocalDB)\v11.0;AttachDbFilename="+path +"EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30";
            
            using (SqlConnection connection = new SqlConnection())  
            {  
                connection.ConnectionString = connectionString;  
                connection.Open();  
                SqlCommand command = connection.CreateCommand();  
                string sql;               
                sql = "SELECT * FROM dbo.EmployeeInfo where EmployeeId<=100000";  
                command.CommandText = sql;  
                SqlDataReader reader = command.ExecuteReader();  
                while (reader.Read())  
                {  
                    EmployeeData employee = new EmployeeData();  
                    employee.Employee_ID = Convert.ToInt32(reader["EmployeeID"]);  
                    employee.FirstName = Convert.ToString(reader["EmployeeFirstName"]);  
                    employee.LastName = Convert.ToString(reader["EmployeeLastName"]);  
                    employees.Add(employee);  
                }
                reader.Close();
                connection.Close();
                return employees.ToList();  
            }  
        }  
        public EmployeeData getEmployeesbyID(Int32 empId)  
        {
            string path = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;
            EmployeeData employees = new EmployeeData();  
            string connectionString = @"data source=(LocalDB)\v11.0;AttachDbFilename="+ path +"EmployeeDB.mdf;Integrated Security=True;Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection())  
            {  
                connection.ConnectionString = connectionString;  
                connection.Open();  
                SqlCommand command = connection.CreateCommand();
                string sql = "SELECT * FROM  dbo.EmployeeInfo where Employeeid=" + empId;  
                command.CommandText = sql;  
                SqlDataReader reader = command.ExecuteReader();  
                while (reader.Read())  
                {  
                    employees.Employee_ID = empId;  
                    employees.FirstName = Convert.ToString(reader["EmployeeFirstName"]);  
                    employees.LastName = Convert.ToString(reader["EmployeeLastName"]);  
                }
                reader.Close();
                connection.Close();
            }  
            return employees;  
        }  
    }  
    
}
