﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LPG_Distribution_System.MainService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DistributorUser", Namespace="http://schemas.datacontract.org/2004/07/WcfService2")]
    [System.SerializableAttribute()]
    public partial class DistributorUser : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AgencyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContectNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DisIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DistributorCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistributorNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DistrictField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GSTINField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LicenceExpiryDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime LicenceIssueDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PANnumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TalukaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AgencyName {
            get {
                return this.AgencyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AgencyNameField, value) != true)) {
                    this.AgencyNameField = value;
                    this.RaisePropertyChanged("AgencyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContectNo {
            get {
                return this.ContectNoField;
            }
            set {
                if ((object.ReferenceEquals(this.ContectNoField, value) != true)) {
                    this.ContectNoField = value;
                    this.RaisePropertyChanged("ContectNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DisId {
            get {
                return this.DisIdField;
            }
            set {
                if ((this.DisIdField.Equals(value) != true)) {
                    this.DisIdField = value;
                    this.RaisePropertyChanged("DisId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DistributorCode {
            get {
                return this.DistributorCodeField;
            }
            set {
                if ((this.DistributorCodeField.Equals(value) != true)) {
                    this.DistributorCodeField = value;
                    this.RaisePropertyChanged("DistributorCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DistributorName {
            get {
                return this.DistributorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DistributorNameField, value) != true)) {
                    this.DistributorNameField = value;
                    this.RaisePropertyChanged("DistributorName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string District {
            get {
                return this.DistrictField;
            }
            set {
                if ((object.ReferenceEquals(this.DistrictField, value) != true)) {
                    this.DistrictField = value;
                    this.RaisePropertyChanged("District");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GSTIN {
            get {
                return this.GSTINField;
            }
            set {
                if ((object.ReferenceEquals(this.GSTINField, value) != true)) {
                    this.GSTINField = value;
                    this.RaisePropertyChanged("GSTIN");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LicenceExpiryDate {
            get {
                return this.LicenceExpiryDateField;
            }
            set {
                if ((this.LicenceExpiryDateField.Equals(value) != true)) {
                    this.LicenceExpiryDateField = value;
                    this.RaisePropertyChanged("LicenceExpiryDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime LicenceIssueDate {
            get {
                return this.LicenceIssueDateField;
            }
            set {
                if ((this.LicenceIssueDateField.Equals(value) != true)) {
                    this.LicenceIssueDateField = value;
                    this.RaisePropertyChanged("LicenceIssueDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PANnumber {
            get {
                return this.PANnumberField;
            }
            set {
                if ((object.ReferenceEquals(this.PANnumberField, value) != true)) {
                    this.PANnumberField = value;
                    this.RaisePropertyChanged("PANnumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Taluka {
            get {
                return this.TalukaField;
            }
            set {
                if ((object.ReferenceEquals(this.TalukaField, value) != true)) {
                    this.TalukaField = value;
                    this.RaisePropertyChanged("Taluka");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MainService.IMainService")]
    public interface IMainService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetDistributor", ReplyAction="http://tempuri.org/IMainService/GetDistributorResponse")]
        LPG_Distribution_System.MainService.DistributorUser GetDistributor();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetDistributor", ReplyAction="http://tempuri.org/IMainService/GetDistributorResponse")]
        System.Threading.Tasks.Task<LPG_Distribution_System.MainService.DistributorUser> GetDistributorAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/TestConnection", ReplyAction="http://tempuri.org/IMainService/TestConnectionResponse")]
        string TestConnection();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/TestConnection", ReplyAction="http://tempuri.org/IMainService/TestConnectionResponse")]
        System.Threading.Tasks.Task<string> TestConnectionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetPassword", ReplyAction="http://tempuri.org/IMainService/GetPasswordResponse")]
        string GetPassword(int dcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetPassword", ReplyAction="http://tempuri.org/IMainService/GetPasswordResponse")]
        System.Threading.Tasks.Task<string> GetPasswordAsync(int dcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/SetPassword", ReplyAction="http://tempuri.org/IMainService/SetPasswordResponse")]
        string SetPassword(string newpass, int dcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/SetPassword", ReplyAction="http://tempuri.org/IMainService/SetPasswordResponse")]
        System.Threading.Tasks.Task<string> SetPasswordAsync(string newpass, int dcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/Login", ReplyAction="http://tempuri.org/IMainService/LoginResponse")]
        LPG_Distribution_System.MainService.DistributorUser Login(string unm, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/Login", ReplyAction="http://tempuri.org/IMainService/LoginResponse")]
        System.Threading.Tasks.Task<LPG_Distribution_System.MainService.DistributorUser> LoginAsync(string unm, string pass);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMainServiceChannel : LPG_Distribution_System.MainService.IMainService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MainServiceClient : System.ServiceModel.ClientBase<LPG_Distribution_System.MainService.IMainService>, LPG_Distribution_System.MainService.IMainService {
        
        public MainServiceClient() {
        }
        
        public MainServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MainServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LPG_Distribution_System.MainService.DistributorUser GetDistributor() {
            return base.Channel.GetDistributor();
        }
        
        public System.Threading.Tasks.Task<LPG_Distribution_System.MainService.DistributorUser> GetDistributorAsync() {
            return base.Channel.GetDistributorAsync();
        }
        
        public string TestConnection() {
            return base.Channel.TestConnection();
        }
        
        public System.Threading.Tasks.Task<string> TestConnectionAsync() {
            return base.Channel.TestConnectionAsync();
        }
        
        public string GetPassword(int dcode) {
            return base.Channel.GetPassword(dcode);
        }
        
        public System.Threading.Tasks.Task<string> GetPasswordAsync(int dcode) {
            return base.Channel.GetPasswordAsync(dcode);
        }
        
        public string SetPassword(string newpass, int dcode) {
            return base.Channel.SetPassword(newpass, dcode);
        }
        
        public System.Threading.Tasks.Task<string> SetPasswordAsync(string newpass, int dcode) {
            return base.Channel.SetPasswordAsync(newpass, dcode);
        }
        
        public LPG_Distribution_System.MainService.DistributorUser Login(string unm, string pass) {
            return base.Channel.Login(unm, pass);
        }
        
        public System.Threading.Tasks.Task<LPG_Distribution_System.MainService.DistributorUser> LoginAsync(string unm, string pass) {
            return base.Channel.LoginAsync(unm, pass);
        }
    }
}
