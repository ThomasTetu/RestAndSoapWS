﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientVelibConsole.SOAPVelibReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/SOAPVelib")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int availableBikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string cityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int availableBikes {
            get {
                return this.availableBikesField;
            }
            set {
                if ((this.availableBikesField.Equals(value) != true)) {
                    this.availableBikesField = value;
                    this.RaisePropertyChanged("availableBikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string city {
            get {
                return this.cityField;
            }
            set {
                if ((object.ReferenceEquals(this.cityField, value) != true)) {
                    this.cityField = value;
                    this.RaisePropertyChanged("city");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SOAPVelibReference.IVelibOperations")]
    public interface IVelibOperations {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibOperations/GetStations", ReplyAction="http://tempuri.org/IVelibOperations/GetStationsResponse")]
        string[] GetStations(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibOperations/GetStations", ReplyAction="http://tempuri.org/IVelibOperations/GetStationsResponse")]
        System.Threading.Tasks.Task<string[]> GetStationsAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibOperations/GetContracts", ReplyAction="http://tempuri.org/IVelibOperations/GetContractsResponse")]
        string[] GetContracts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibOperations/GetContracts", ReplyAction="http://tempuri.org/IVelibOperations/GetContractsResponse")]
        System.Threading.Tasks.Task<string[]> GetContractsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibOperations/GetStationData", ReplyAction="http://tempuri.org/IVelibOperations/GetStationDataResponse")]
        ClientVelibConsole.SOAPVelibReference.Station GetStationData(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibOperations/GetStationData", ReplyAction="http://tempuri.org/IVelibOperations/GetStationDataResponse")]
        System.Threading.Tasks.Task<ClientVelibConsole.SOAPVelibReference.Station> GetStationDataAsync(string city, string station);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibOperationsChannel : ClientVelibConsole.SOAPVelibReference.IVelibOperations, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VelibOperationsClient : System.ServiceModel.ClientBase<ClientVelibConsole.SOAPVelibReference.IVelibOperations>, ClientVelibConsole.SOAPVelibReference.IVelibOperations {
        
        public VelibOperationsClient() {
        }
        
        public VelibOperationsClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VelibOperationsClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VelibOperationsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VelibOperationsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetStations(string city) {
            return base.Channel.GetStations(city);
        }
        
        public System.Threading.Tasks.Task<string[]> GetStationsAsync(string city) {
            return base.Channel.GetStationsAsync(city);
        }
        
        public string[] GetContracts() {
            return base.Channel.GetContracts();
        }
        
        public System.Threading.Tasks.Task<string[]> GetContractsAsync() {
            return base.Channel.GetContractsAsync();
        }
        
        public ClientVelibConsole.SOAPVelibReference.Station GetStationData(string city, string station) {
            return base.Channel.GetStationData(city, station);
        }
        
        public System.Threading.Tasks.Task<ClientVelibConsole.SOAPVelibReference.Station> GetStationDataAsync(string city, string station) {
            return base.Channel.GetStationDataAsync(city, station);
        }
    }
}
