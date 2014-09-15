﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.35317
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace paymentSOA.bankService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="bankEntity", Namespace="http://schemas.datacontract.org/2004/07/bankService")]
    [System.SerializableAttribute()]
    public partial class bankEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PayIdField;
        
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
        public string PayId {
            get {
                return this.PayIdField;
            }
            set {
                if ((object.ReferenceEquals(this.PayIdField, value) != true)) {
                    this.PayIdField = value;
                    this.RaisePropertyChanged("PayId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="bankService.IBankService")]
    public interface IBankService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/processPayment", ReplyAction="http://tempuri.org/IBankService/processPaymentResponse")]
        void processPayment(paymentSOA.bankService.bankEntity payEntity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBankService/processPaymentHelp", ReplyAction="http://tempuri.org/IBankService/processPaymentHelpResponse")]
        void processPaymentHelp(paymentSOA.bankService.bankEntity payEntity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBankServiceChannel : paymentSOA.bankService.IBankService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankServiceClient : System.ServiceModel.ClientBase<paymentSOA.bankService.IBankService>, paymentSOA.bankService.IBankService {
        
        public BankServiceClient() {
        }
        
        public BankServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BankServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void processPayment(paymentSOA.bankService.bankEntity payEntity) {
            base.Channel.processPayment(payEntity);
        }
        
        public void processPaymentHelp(paymentSOA.bankService.bankEntity payEntity) {
            base.Channel.processPaymentHelp(payEntity);
        }
    }
}
