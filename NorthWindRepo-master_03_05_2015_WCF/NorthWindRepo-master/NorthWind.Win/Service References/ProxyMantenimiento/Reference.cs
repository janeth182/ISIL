﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18408
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthWind.Win.ProxyMantenimiento {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EventArgs", Namespace="http://schemas.datacontract.org/2004/07/System")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(NorthWind.Entity.TbClienteBE))]
    public partial class EventArgs : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProxyMantenimiento.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectAllClients", ReplyAction="http://tempuri.org/IService1/SelectAllClientsResponse")]
        System.Collections.Generic.List<NorthWind.Entity.TbClienteBE> SelectAllClients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectAllClients", ReplyAction="http://tempuri.org/IService1/SelectAllClientsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<NorthWind.Entity.TbClienteBE>> SelectAllClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectAllProducts", ReplyAction="http://tempuri.org/IService1/SelectAllProductsResponse")]
        System.Collections.Generic.List<NorthWind.Entity.TbProductoBE> SelectAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SelectAllProducts", ReplyAction="http://tempuri.org/IService1/SelectAllProductsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<NorthWind.Entity.TbProductoBE>> SelectAllProductsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : NorthWind.Win.ProxyMantenimiento.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<NorthWind.Win.ProxyMantenimiento.IService1>, NorthWind.Win.ProxyMantenimiento.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<NorthWind.Entity.TbClienteBE> SelectAllClients() {
            return base.Channel.SelectAllClients();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<NorthWind.Entity.TbClienteBE>> SelectAllClientsAsync() {
            return base.Channel.SelectAllClientsAsync();
        }
        
        public System.Collections.Generic.List<NorthWind.Entity.TbProductoBE> SelectAllProducts() {
            return base.Channel.SelectAllProducts();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<NorthWind.Entity.TbProductoBE>> SelectAllProductsAsync() {
            return base.Channel.SelectAllProductsAsync();
        }
    }
}
