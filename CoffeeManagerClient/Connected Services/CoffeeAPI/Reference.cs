﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoffeeManagerClient.CoffeeAPI {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.coffee.com/samples/01", ConfigurationName="CoffeeAPI.CoffeeServiceContract")]
    public interface CoffeeServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.coffee.com/samples/01/CoffeeServiceContract/SaveCoffee", ReplyAction="http://www.coffee.com/samples/01/CoffeeServiceContract/SaveCoffeeResponse")]
        void SaveCoffee(ContentType.Coffee coffee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.coffee.com/samples/01/CoffeeServiceContract/SaveCoffee", ReplyAction="http://www.coffee.com/samples/01/CoffeeServiceContract/SaveCoffeeResponse")]
        System.Threading.Tasks.Task SaveCoffeeAsync(ContentType.Coffee coffee);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.coffee.com/samples/01/CoffeeServiceContract/GetCoffee", ReplyAction="http://www.coffee.com/samples/01/CoffeeServiceContract/GetCoffeeResponse")]
        ContentType.Coffee GetCoffee();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.coffee.com/samples/01/CoffeeServiceContract/GetCoffee", ReplyAction="http://www.coffee.com/samples/01/CoffeeServiceContract/GetCoffeeResponse")]
        System.Threading.Tasks.Task<ContentType.Coffee> GetCoffeeAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CoffeeServiceContractChannel : CoffeeManagerClient.CoffeeAPI.CoffeeServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CoffeeServiceContractClient : System.ServiceModel.ClientBase<CoffeeManagerClient.CoffeeAPI.CoffeeServiceContract>, CoffeeManagerClient.CoffeeAPI.CoffeeServiceContract {
        
        public CoffeeServiceContractClient() {
        }
        
        public CoffeeServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CoffeeServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoffeeServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CoffeeServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void SaveCoffee(ContentType.Coffee coffee) {
            base.Channel.SaveCoffee(coffee);
        }
        
        public System.Threading.Tasks.Task SaveCoffeeAsync(ContentType.Coffee coffee) {
            return base.Channel.SaveCoffeeAsync(coffee);
        }
        
        public ContentType.Coffee GetCoffee() {
            return base.Channel.GetCoffee();
        }
        
        public System.Threading.Tasks.Task<ContentType.Coffee> GetCoffeeAsync() {
            return base.Channel.GetCoffeeAsync();
        }
    }
}
