﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCClient.EmployeeServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeDetail", Namespace="http://schemas.datacontract.org/2004/07/EmployeeService")]
    [System.SerializableAttribute()]
    public partial class EmployeeDetail : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DesignationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Designation {
            get {
                return this.DesignationField;
            }
            set {
                if ((object.ReferenceEquals(this.DesignationField, value) != true)) {
                    this.DesignationField = value;
                    this.RaisePropertyChanged("Designation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmployeeServiceReference.IEmployeeService")]
    public interface IEmployeeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/AddEmployee", ReplyAction="http://tempuri.org/IEmployeeService/AddEmployeeResponse")]
        string AddEmployee(MVCClient.EmployeeServiceReference.EmployeeDetail employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/AddEmployee", ReplyAction="http://tempuri.org/IEmployeeService/AddEmployeeResponse")]
        System.Threading.Tasks.Task<string> AddEmployeeAsync(MVCClient.EmployeeServiceReference.EmployeeDetail employee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/RetreiveEmployees", ReplyAction="http://tempuri.org/IEmployeeService/RetreiveEmployeesResponse")]
        MVCClient.EmployeeServiceReference.EmployeeDetail[] RetreiveEmployees();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/RetreiveEmployees", ReplyAction="http://tempuri.org/IEmployeeService/RetreiveEmployeesResponse")]
        System.Threading.Tasks.Task<MVCClient.EmployeeServiceReference.EmployeeDetail[]> RetreiveEmployeesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/RetreiveEmployeeByID", ReplyAction="http://tempuri.org/IEmployeeService/RetreiveEmployeeByIDResponse")]
        MVCClient.EmployeeServiceReference.EmployeeDetail RetreiveEmployeeByID(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/RetreiveEmployeeByID", ReplyAction="http://tempuri.org/IEmployeeService/RetreiveEmployeeByIDResponse")]
        System.Threading.Tasks.Task<MVCClient.EmployeeServiceReference.EmployeeDetail> RetreiveEmployeeByIDAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployeeService/UpdateEmployeeResponse")]
        MVCClient.EmployeeServiceReference.EmployeeDetail[] UpdateEmployee(MVCClient.EmployeeServiceReference.EmployeeDetail id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/UpdateEmployee", ReplyAction="http://tempuri.org/IEmployeeService/UpdateEmployeeResponse")]
        System.Threading.Tasks.Task<MVCClient.EmployeeServiceReference.EmployeeDetail[]> UpdateEmployeeAsync(MVCClient.EmployeeServiceReference.EmployeeDetail id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/DeleteEmployee", ReplyAction="http://tempuri.org/IEmployeeService/DeleteEmployeeResponse")]
        MVCClient.EmployeeServiceReference.EmployeeDetail[] DeleteEmployee(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmployeeService/DeleteEmployee", ReplyAction="http://tempuri.org/IEmployeeService/DeleteEmployeeResponse")]
        System.Threading.Tasks.Task<MVCClient.EmployeeServiceReference.EmployeeDetail[]> DeleteEmployeeAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmployeeServiceChannel : MVCClient.EmployeeServiceReference.IEmployeeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmployeeServiceClient : System.ServiceModel.ClientBase<MVCClient.EmployeeServiceReference.IEmployeeService>, MVCClient.EmployeeServiceReference.IEmployeeService {
        
        public EmployeeServiceClient() {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmployeeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddEmployee(MVCClient.EmployeeServiceReference.EmployeeDetail employee) {
            return base.Channel.AddEmployee(employee);
        }
        
        public System.Threading.Tasks.Task<string> AddEmployeeAsync(MVCClient.EmployeeServiceReference.EmployeeDetail employee) {
            return base.Channel.AddEmployeeAsync(employee);
        }
        
        public MVCClient.EmployeeServiceReference.EmployeeDetail[] RetreiveEmployees() {
            return base.Channel.RetreiveEmployees();
        }
        
        public System.Threading.Tasks.Task<MVCClient.EmployeeServiceReference.EmployeeDetail[]> RetreiveEmployeesAsync() {
            return base.Channel.RetreiveEmployeesAsync();
        }
        
        public MVCClient.EmployeeServiceReference.EmployeeDetail RetreiveEmployeeByID(int id) {
            return base.Channel.RetreiveEmployeeByID(id);
        }
        
        public System.Threading.Tasks.Task<MVCClient.EmployeeServiceReference.EmployeeDetail> RetreiveEmployeeByIDAsync(int id) {
            return base.Channel.RetreiveEmployeeByIDAsync(id);
        }
        
        public MVCClient.EmployeeServiceReference.EmployeeDetail[] UpdateEmployee(MVCClient.EmployeeServiceReference.EmployeeDetail id) {
            return base.Channel.UpdateEmployee(id);
        }
        
        public System.Threading.Tasks.Task<MVCClient.EmployeeServiceReference.EmployeeDetail[]> UpdateEmployeeAsync(MVCClient.EmployeeServiceReference.EmployeeDetail id) {
            return base.Channel.UpdateEmployeeAsync(id);
        }
        
        public MVCClient.EmployeeServiceReference.EmployeeDetail[] DeleteEmployee(int id) {
            return base.Channel.DeleteEmployee(id);
        }
        
        public System.Threading.Tasks.Task<MVCClient.EmployeeServiceReference.EmployeeDetail[]> DeleteEmployeeAsync(int id) {
            return base.Channel.DeleteEmployeeAsync(id);
        }
    }
}
