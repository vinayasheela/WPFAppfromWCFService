﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee.EmployeeInfoService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeData", Namespace="http://schemas.datacontract.org/2004/07/EmployeeInfoService")]
    [System.SerializableAttribute()]
    public partial class EmployeeData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Employee_IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Employee_ID {
            get {
                return this.Employee_IDField;
            }
            set {
                if ((this.Employee_IDField.Equals(value) != true)) {
                    this.Employee_IDField = value;
                    this.RaisePropertyChanged("Employee_ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeInfoService.IEmployeeInfo")]
    public interface IEmployeeInfo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeInfo/getEmployees", ReplyAction="http://tempuri.org/IEmployeeInfo/getEmployeesResponse")]
        Employee.EmployeeInfoService.EmployeeData[] getEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeInfo/getEmployees", ReplyAction="http://tempuri.org/IEmployeeInfo/getEmployeesResponse")]
        System.Threading.Tasks.Task<Employee.EmployeeInfoService.EmployeeData[]> getEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeInfo/getEmployeesbyID", ReplyAction="http://tempuri.org/IEmployeeInfo/getEmployeesbyIDResponse")]
        Employee.EmployeeInfoService.EmployeeData getEmployeesbyID(int empId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeInfo/getEmployeesbyID", ReplyAction="http://tempuri.org/IEmployeeInfo/getEmployeesbyIDResponse")]
        System.Threading.Tasks.Task<Employee.EmployeeInfoService.EmployeeData> getEmployeesbyIDAsync(int empId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeInfoChannel : Employee.EmployeeInfoService.IEmployeeInfo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeInfoClient : System.ServiceModel.ClientBase<Employee.EmployeeInfoService.IEmployeeInfo>, Employee.EmployeeInfoService.IEmployeeInfo {
        
        public EmployeeInfoClient() {
        }
        
        public EmployeeInfoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeInfoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeInfoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeInfoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Employee.EmployeeInfoService.EmployeeData[] getEmployees() {
            return base.Channel.getEmployees();
        }
        
        public System.Threading.Tasks.Task<Employee.EmployeeInfoService.EmployeeData[]> getEmployeesAsync() {
            return base.Channel.getEmployeesAsync();
        }
        
        public Employee.EmployeeInfoService.EmployeeData getEmployeesbyID(int empId) {
            return base.Channel.getEmployeesbyID(empId);
        }
        
        public System.Threading.Tasks.Task<Employee.EmployeeInfoService.EmployeeData> getEmployeesbyIDAsync(int empId) {
            return base.Channel.getEmployeesbyIDAsync(empId);
        }
    }
}
