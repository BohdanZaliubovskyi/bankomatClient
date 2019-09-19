﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankomatClient.BankomatLocalService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cards", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Cards : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CardNumberField;
        
        private long PinField;
        
        private long CardStatusField;
        
        private bool IsBlockedField;
        
        private System.DateTime DateOfEndUsingField;
        
        private long ClientIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BankomatClient.BankomatLocalService.Clients ClientsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string CardNumber {
            get {
                return this.CardNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.CardNumberField, value) != true)) {
                    this.CardNumberField = value;
                    this.RaisePropertyChanged("CardNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public long Pin {
            get {
                return this.PinField;
            }
            set {
                if ((this.PinField.Equals(value) != true)) {
                    this.PinField = value;
                    this.RaisePropertyChanged("Pin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public long CardStatus {
            get {
                return this.CardStatusField;
            }
            set {
                if ((this.CardStatusField.Equals(value) != true)) {
                    this.CardStatusField = value;
                    this.RaisePropertyChanged("CardStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool IsBlocked {
            get {
                return this.IsBlockedField;
            }
            set {
                if ((this.IsBlockedField.Equals(value) != true)) {
                    this.IsBlockedField = value;
                    this.RaisePropertyChanged("IsBlocked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.DateTime DateOfEndUsing {
            get {
                return this.DateOfEndUsingField;
            }
            set {
                if ((this.DateOfEndUsingField.Equals(value) != true)) {
                    this.DateOfEndUsingField = value;
                    this.RaisePropertyChanged("DateOfEndUsing");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public long ClientId {
            get {
                return this.ClientIdField;
            }
            set {
                if ((this.ClientIdField.Equals(value) != true)) {
                    this.ClientIdField = value;
                    this.RaisePropertyChanged("ClientId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public BankomatClient.BankomatLocalService.Clients Clients {
            get {
                return this.ClientsField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientsField, value) != true)) {
                    this.ClientsField = value;
                    this.RaisePropertyChanged("Clients");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Clients", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Clients : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private long IdField;
        
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long Id {
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BankomatLocalService.BankomatServiceSoap")]
    public interface BankomatServiceSoap {
        
        // CODEGEN: Generating message contract since element name cardNumber from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckCardNumber", ReplyAction="*")]
        BankomatClient.BankomatLocalService.CheckCardNumberResponse CheckCardNumber(BankomatClient.BankomatLocalService.CheckCardNumberRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CheckCardNumber", ReplyAction="*")]
        System.Threading.Tasks.Task<BankomatClient.BankomatLocalService.CheckCardNumberResponse> CheckCardNumberAsync(BankomatClient.BankomatLocalService.CheckCardNumberRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckCardNumberRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckCardNumber", Namespace="http://tempuri.org/", Order=0)]
        public BankomatClient.BankomatLocalService.CheckCardNumberRequestBody Body;
        
        public CheckCardNumberRequest() {
        }
        
        public CheckCardNumberRequest(BankomatClient.BankomatLocalService.CheckCardNumberRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckCardNumberRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string cardNumber;
        
        public CheckCardNumberRequestBody() {
        }
        
        public CheckCardNumberRequestBody(string cardNumber) {
            this.cardNumber = cardNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CheckCardNumberResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CheckCardNumberResponse", Namespace="http://tempuri.org/", Order=0)]
        public BankomatClient.BankomatLocalService.CheckCardNumberResponseBody Body;
        
        public CheckCardNumberResponse() {
        }
        
        public CheckCardNumberResponse(BankomatClient.BankomatLocalService.CheckCardNumberResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CheckCardNumberResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BankomatClient.BankomatLocalService.Cards CheckCardNumberResult;
        
        public CheckCardNumberResponseBody() {
        }
        
        public CheckCardNumberResponseBody(BankomatClient.BankomatLocalService.Cards CheckCardNumberResult) {
            this.CheckCardNumberResult = CheckCardNumberResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BankomatServiceSoapChannel : BankomatClient.BankomatLocalService.BankomatServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BankomatServiceSoapClient : System.ServiceModel.ClientBase<BankomatClient.BankomatLocalService.BankomatServiceSoap>, BankomatClient.BankomatLocalService.BankomatServiceSoap {
        
        public BankomatServiceSoapClient() {
        }
        
        public BankomatServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BankomatServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankomatServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BankomatServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BankomatClient.BankomatLocalService.CheckCardNumberResponse BankomatClient.BankomatLocalService.BankomatServiceSoap.CheckCardNumber(BankomatClient.BankomatLocalService.CheckCardNumberRequest request) {
            return base.Channel.CheckCardNumber(request);
        }
        
        public BankomatClient.BankomatLocalService.Cards CheckCardNumber(string cardNumber) {
            BankomatClient.BankomatLocalService.CheckCardNumberRequest inValue = new BankomatClient.BankomatLocalService.CheckCardNumberRequest();
            inValue.Body = new BankomatClient.BankomatLocalService.CheckCardNumberRequestBody();
            inValue.Body.cardNumber = cardNumber;
            BankomatClient.BankomatLocalService.CheckCardNumberResponse retVal = ((BankomatClient.BankomatLocalService.BankomatServiceSoap)(this)).CheckCardNumber(inValue);
            return retVal.Body.CheckCardNumberResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BankomatClient.BankomatLocalService.CheckCardNumberResponse> BankomatClient.BankomatLocalService.BankomatServiceSoap.CheckCardNumberAsync(BankomatClient.BankomatLocalService.CheckCardNumberRequest request) {
            return base.Channel.CheckCardNumberAsync(request);
        }
        
        public System.Threading.Tasks.Task<BankomatClient.BankomatLocalService.CheckCardNumberResponse> CheckCardNumberAsync(string cardNumber) {
            BankomatClient.BankomatLocalService.CheckCardNumberRequest inValue = new BankomatClient.BankomatLocalService.CheckCardNumberRequest();
            inValue.Body = new BankomatClient.BankomatLocalService.CheckCardNumberRequestBody();
            inValue.Body.cardNumber = cardNumber;
            return ((BankomatClient.BankomatLocalService.BankomatServiceSoap)(this)).CheckCardNumberAsync(inValue);
        }
    }
}
