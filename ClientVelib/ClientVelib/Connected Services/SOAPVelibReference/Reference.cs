﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientVelib.SOAPVelibReference {
    
    
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibOperations/GetNbAvailableBikes", ReplyAction="http://tempuri.org/IVelibOperations/GetNbAvailableBikesResponse")]
        int GetNbAvailableBikes(string city, string station);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibOperations/GetNbAvailableBikes", ReplyAction="http://tempuri.org/IVelibOperations/GetNbAvailableBikesResponse")]
        System.Threading.Tasks.Task<int> GetNbAvailableBikesAsync(string city, string station);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibOperationsChannel : ClientVelib.SOAPVelibReference.IVelibOperations, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VelibOperationsClient : System.ServiceModel.ClientBase<ClientVelib.SOAPVelibReference.IVelibOperations>, ClientVelib.SOAPVelibReference.IVelibOperations {
        
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
        
        public int GetNbAvailableBikes(string city, string station) {
            return base.Channel.GetNbAvailableBikes(city, station);
        }
        
        public System.Threading.Tasks.Task<int> GetNbAvailableBikesAsync(string city, string station) {
            return base.Channel.GetNbAvailableBikesAsync(city, station);
        }
    }
}
