﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ConsoleApp1.ServiceReference1.HelloWorldResponse HelloWorld(ConsoleApp1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.HelloWorldResponse> HelloWorldAsync(ConsoleApp1.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name KTchanleResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KTchanle", ReplyAction="*")]
        ConsoleApp1.ServiceReference1.KTchanleResponse KTchanle(ConsoleApp1.ServiceReference1.KTchanleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/KTchanle", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.KTchanleResponse> KTchanleAsync(ConsoleApp1.ServiceReference1.KTchanleRequest request);
        
        // CODEGEN: Generating message contract since element name FindMinMaxResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindMinMax", ReplyAction="*")]
        ConsoleApp1.ServiceReference1.FindMinMaxResponse FindMinMax(ConsoleApp1.ServiceReference1.FindMinMaxRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FindMinMax", ReplyAction="*")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.FindMinMaxResponse> FindMinMaxAsync(ConsoleApp1.ServiceReference1.FindMinMaxRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ConsoleApp1.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ConsoleApp1.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class KTchanleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="KTchanle", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.KTchanleRequestBody Body;
        
        public KTchanleRequest() {
        }
        
        public KTchanleRequest(ConsoleApp1.ServiceReference1.KTchanleRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class KTchanleRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int n;
        
        public KTchanleRequestBody() {
        }
        
        public KTchanleRequestBody(int n) {
            this.n = n;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class KTchanleResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="KTchanleResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.KTchanleResponseBody Body;
        
        public KTchanleResponse() {
        }
        
        public KTchanleResponse(ConsoleApp1.ServiceReference1.KTchanleResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class KTchanleResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string KTchanleResult;
        
        public KTchanleResponseBody() {
        }
        
        public KTchanleResponseBody(string KTchanleResult) {
            this.KTchanleResult = KTchanleResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindMinMaxRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindMinMax", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.FindMinMaxRequestBody Body;
        
        public FindMinMaxRequest() {
        }
        
        public FindMinMaxRequest(ConsoleApp1.ServiceReference1.FindMinMaxRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindMinMaxRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int num1;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int num2;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int num3;
        
        public FindMinMaxRequestBody() {
        }
        
        public FindMinMaxRequestBody(int num1, int num2, int num3) {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FindMinMaxResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FindMinMaxResponse", Namespace="http://tempuri.org/", Order=0)]
        public ConsoleApp1.ServiceReference1.FindMinMaxResponseBody Body;
        
        public FindMinMaxResponse() {
        }
        
        public FindMinMaxResponse(ConsoleApp1.ServiceReference1.FindMinMaxResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class FindMinMaxResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string FindMinMaxResult;
        
        public FindMinMaxResponseBody() {
        }
        
        public FindMinMaxResponseBody(string FindMinMaxResult) {
            this.FindMinMaxResult = FindMinMaxResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : ConsoleApp1.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ConsoleApp1.ServiceReference1.WebService1Soap>, ConsoleApp1.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.ServiceReference1.HelloWorldResponse ConsoleApp1.ServiceReference1.WebService1Soap.HelloWorld(ConsoleApp1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ConsoleApp1.ServiceReference1.HelloWorldRequest inValue = new ConsoleApp1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.HelloWorldRequestBody();
            ConsoleApp1.ServiceReference1.HelloWorldResponse retVal = ((ConsoleApp1.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.HelloWorldResponse> ConsoleApp1.ServiceReference1.WebService1Soap.HelloWorldAsync(ConsoleApp1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            ConsoleApp1.ServiceReference1.HelloWorldRequest inValue = new ConsoleApp1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.HelloWorldRequestBody();
            return ((ConsoleApp1.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.ServiceReference1.KTchanleResponse ConsoleApp1.ServiceReference1.WebService1Soap.KTchanle(ConsoleApp1.ServiceReference1.KTchanleRequest request) {
            return base.Channel.KTchanle(request);
        }
        
        public string KTchanle(int n) {
            ConsoleApp1.ServiceReference1.KTchanleRequest inValue = new ConsoleApp1.ServiceReference1.KTchanleRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.KTchanleRequestBody();
            inValue.Body.n = n;
            ConsoleApp1.ServiceReference1.KTchanleResponse retVal = ((ConsoleApp1.ServiceReference1.WebService1Soap)(this)).KTchanle(inValue);
            return retVal.Body.KTchanleResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.KTchanleResponse> ConsoleApp1.ServiceReference1.WebService1Soap.KTchanleAsync(ConsoleApp1.ServiceReference1.KTchanleRequest request) {
            return base.Channel.KTchanleAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.KTchanleResponse> KTchanleAsync(int n) {
            ConsoleApp1.ServiceReference1.KTchanleRequest inValue = new ConsoleApp1.ServiceReference1.KTchanleRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.KTchanleRequestBody();
            inValue.Body.n = n;
            return ((ConsoleApp1.ServiceReference1.WebService1Soap)(this)).KTchanleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.ServiceReference1.FindMinMaxResponse ConsoleApp1.ServiceReference1.WebService1Soap.FindMinMax(ConsoleApp1.ServiceReference1.FindMinMaxRequest request) {
            return base.Channel.FindMinMax(request);
        }
        
        public string FindMinMax(int num1, int num2, int num3) {
            ConsoleApp1.ServiceReference1.FindMinMaxRequest inValue = new ConsoleApp1.ServiceReference1.FindMinMaxRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.FindMinMaxRequestBody();
            inValue.Body.num1 = num1;
            inValue.Body.num2 = num2;
            inValue.Body.num3 = num3;
            ConsoleApp1.ServiceReference1.FindMinMaxResponse retVal = ((ConsoleApp1.ServiceReference1.WebService1Soap)(this)).FindMinMax(inValue);
            return retVal.Body.FindMinMaxResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.FindMinMaxResponse> ConsoleApp1.ServiceReference1.WebService1Soap.FindMinMaxAsync(ConsoleApp1.ServiceReference1.FindMinMaxRequest request) {
            return base.Channel.FindMinMaxAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.FindMinMaxResponse> FindMinMaxAsync(int num1, int num2, int num3) {
            ConsoleApp1.ServiceReference1.FindMinMaxRequest inValue = new ConsoleApp1.ServiceReference1.FindMinMaxRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.FindMinMaxRequestBody();
            inValue.Body.num1 = num1;
            inValue.Body.num2 = num2;
            inValue.Body.num3 = num3;
            return ((ConsoleApp1.ServiceReference1.WebService1Soap)(this)).FindMinMaxAsync(inValue);
        }
    }
}
