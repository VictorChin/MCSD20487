﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace C3.ClientUsingDuplex.DuplexServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Numbers", Namespace="http://schemas.datacontract.org/2004/07/Firebrand")]
    [System.SerializableAttribute()]
    public partial class Numbers : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double BField;
        
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
        public double A {
            get {
                return this.AField;
            }
            set {
                if ((this.AField.Equals(value) != true)) {
                    this.AField = value;
                    this.RaisePropertyChanged("A");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double B {
            get {
                return this.BField;
            }
            set {
                if ((this.BField.Equals(value) != true)) {
                    this.BField = value;
                    this.RaisePropertyChanged("B");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DuplexServiceReference.ICalcDuplex", CallbackContract=typeof(C3.ClientUsingDuplex.DuplexServiceReference.ICalcDuplexCallback))]
    public interface ICalcDuplex {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalcDuplex/Divide")]
        void Divide(C3.ClientUsingDuplex.DuplexServiceReference.Numbers n);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalcDuplex/Divide")]
        System.Threading.Tasks.Task DivideAsync(C3.ClientUsingDuplex.DuplexServiceReference.Numbers n);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcDuplexCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/ICalcDuplex/SendAnswer")]
        void SendAnswer(double answer);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalcDuplexChannel : C3.ClientUsingDuplex.DuplexServiceReference.ICalcDuplex, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcDuplexClient : System.ServiceModel.DuplexClientBase<C3.ClientUsingDuplex.DuplexServiceReference.ICalcDuplex>, C3.ClientUsingDuplex.DuplexServiceReference.ICalcDuplex {
        
        public CalcDuplexClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public CalcDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public CalcDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalcDuplexClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public CalcDuplexClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Divide(C3.ClientUsingDuplex.DuplexServiceReference.Numbers n) {
            base.Channel.Divide(n);
        }
        
        public System.Threading.Tasks.Task DivideAsync(C3.ClientUsingDuplex.DuplexServiceReference.Numbers n) {
            return base.Channel.DivideAsync(n);
        }
    }
}
