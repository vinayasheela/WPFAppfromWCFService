using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EmployeeInfoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeInfo
    {

        [OperationContract]
        List<EmployeeData> getEmployees();

        [OperationContract]
        EmployeeData getEmployeesbyID(Int32 empId);  

        // TODO: Add your service operations here
    }


    [DataContract]
    public class EmployeeData
    {
        public Int32 _employee_ID;
        public string _firstName;
        public string _lastName;

        [DataMember]
        public Int32 Employee_ID
        {
            get { return _employee_ID; }
            set { _employee_ID = value; }
        }

        [DataMember]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        [DataMember]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
    }  
}
