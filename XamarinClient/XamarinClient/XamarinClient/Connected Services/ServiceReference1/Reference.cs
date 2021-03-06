﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XamarinClient.ServiceReference1 {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SimpleResponse", Namespace="http://schemas.datacontract.org/2004/07/ServiceAbstractions.SimpleService")]
    public partial class SimpleResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string RequestField;
        
        private System.DateTime ResponseTimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Request {
            get {
                return this.RequestField;
            }
            set {
                if ((object.ReferenceEquals(this.RequestField, value) != true)) {
                    this.RequestField = value;
                    this.RaisePropertyChanged("Request");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ResponseTime {
            get {
                return this.ResponseTimeField;
            }
            set {
                if ((this.ResponseTimeField.Equals(value) != true)) {
                    this.ResponseTimeField = value;
                    this.RaisePropertyChanged("ResponseTime");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ISimpleService")]
    public interface ISimpleService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ISimpleService/SinkRequest", ReplyAction="http://tempuri.org/ISimpleService/SinkRequestResponse")]
        System.IAsyncResult BeginSinkRequest(string request, System.AsyncCallback callback, object asyncState);
        
        void EndSinkRequest(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/ISimpleService/GetSimpleResponse", ReplyAction="http://tempuri.org/ISimpleService/GetSimpleResponseResponse")]
        System.IAsyncResult BeginGetSimpleResponse(string request, System.AsyncCallback callback, object asyncState);
        
        XamarinClient.ServiceReference1.SimpleResponse EndGetSimpleResponse(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISimpleServiceChannel : XamarinClient.ServiceReference1.ISimpleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetSimpleResponseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetSimpleResponseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public XamarinClient.ServiceReference1.SimpleResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((XamarinClient.ServiceReference1.SimpleResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SimpleServiceClient : System.ServiceModel.ClientBase<XamarinClient.ServiceReference1.ISimpleService>, XamarinClient.ServiceReference1.ISimpleService {
        
        private BeginOperationDelegate onBeginSinkRequestDelegate;
        
        private EndOperationDelegate onEndSinkRequestDelegate;
        
        private System.Threading.SendOrPostCallback onSinkRequestCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetSimpleResponseDelegate;
        
        private EndOperationDelegate onEndGetSimpleResponseDelegate;
        
        private System.Threading.SendOrPostCallback onGetSimpleResponseCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public SimpleServiceClient() : 
                base(SimpleServiceClient.GetDefaultBinding(), SimpleServiceClient.GetDefaultEndpointAddress()) {
        }
        
        public SimpleServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SimpleServiceClient.GetBindingForEndpoint(endpointConfiguration), SimpleServiceClient.GetEndpointAddress(endpointConfiguration)) {
        }
        
        public SimpleServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SimpleServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
        }
        
        public SimpleServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SimpleServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
        }
        
        public SimpleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SinkRequestCompleted;
        
        public event System.EventHandler<GetSimpleResponseCompletedEventArgs> GetSimpleResponseCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult XamarinClient.ServiceReference1.ISimpleService.BeginSinkRequest(string request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSinkRequest(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void XamarinClient.ServiceReference1.ISimpleService.EndSinkRequest(System.IAsyncResult result) {
            base.Channel.EndSinkRequest(result);
        }
        
        private System.IAsyncResult OnBeginSinkRequest(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string request = ((string)(inValues[0]));
            return ((XamarinClient.ServiceReference1.ISimpleService)(this)).BeginSinkRequest(request, callback, asyncState);
        }
        
        private object[] OnEndSinkRequest(System.IAsyncResult result) {
            ((XamarinClient.ServiceReference1.ISimpleService)(this)).EndSinkRequest(result);
            return null;
        }
        
        private void OnSinkRequestCompleted(object state) {
            if ((this.SinkRequestCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SinkRequestCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SinkRequestAsync(string request) {
            this.SinkRequestAsync(request, null);
        }
        
        public void SinkRequestAsync(string request, object userState) {
            if ((this.onBeginSinkRequestDelegate == null)) {
                this.onBeginSinkRequestDelegate = new BeginOperationDelegate(this.OnBeginSinkRequest);
            }
            if ((this.onEndSinkRequestDelegate == null)) {
                this.onEndSinkRequestDelegate = new EndOperationDelegate(this.OnEndSinkRequest);
            }
            if ((this.onSinkRequestCompletedDelegate == null)) {
                this.onSinkRequestCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSinkRequestCompleted);
            }
            base.InvokeAsync(this.onBeginSinkRequestDelegate, new object[] {
                        request}, this.onEndSinkRequestDelegate, this.onSinkRequestCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult XamarinClient.ServiceReference1.ISimpleService.BeginGetSimpleResponse(string request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetSimpleResponse(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        XamarinClient.ServiceReference1.SimpleResponse XamarinClient.ServiceReference1.ISimpleService.EndGetSimpleResponse(System.IAsyncResult result) {
            return base.Channel.EndGetSimpleResponse(result);
        }
        
        private System.IAsyncResult OnBeginGetSimpleResponse(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string request = ((string)(inValues[0]));
            return ((XamarinClient.ServiceReference1.ISimpleService)(this)).BeginGetSimpleResponse(request, callback, asyncState);
        }
        
        private object[] OnEndGetSimpleResponse(System.IAsyncResult result) {
            XamarinClient.ServiceReference1.SimpleResponse retVal = ((XamarinClient.ServiceReference1.ISimpleService)(this)).EndGetSimpleResponse(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetSimpleResponseCompleted(object state) {
            if ((this.GetSimpleResponseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetSimpleResponseCompleted(this, new GetSimpleResponseCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetSimpleResponseAsync(string request) {
            this.GetSimpleResponseAsync(request, null);
        }
        
        public void GetSimpleResponseAsync(string request, object userState) {
            if ((this.onBeginGetSimpleResponseDelegate == null)) {
                this.onBeginGetSimpleResponseDelegate = new BeginOperationDelegate(this.OnBeginGetSimpleResponse);
            }
            if ((this.onEndGetSimpleResponseDelegate == null)) {
                this.onEndGetSimpleResponseDelegate = new EndOperationDelegate(this.OnEndGetSimpleResponse);
            }
            if ((this.onGetSimpleResponseCompletedDelegate == null)) {
                this.onGetSimpleResponseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetSimpleResponseCompleted);
            }
            base.InvokeAsync(this.onBeginGetSimpleResponseDelegate, new object[] {
                        request}, this.onEndGetSimpleResponseDelegate, this.onGetSimpleResponseCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override XamarinClient.ServiceReference1.ISimpleService CreateChannel() {
            return new SimpleServiceClientChannel(this);
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISimpleService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.MaxReceivedMessageSize = int.MaxValue;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ISimpleService)) {
                return new System.ServiceModel.EndpointAddress("http://localhost:9001/SimpleService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return SimpleServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ISimpleService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return SimpleServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ISimpleService);
        }
        
        private class SimpleServiceClientChannel : ChannelBase<XamarinClient.ServiceReference1.ISimpleService>, XamarinClient.ServiceReference1.ISimpleService {
            
            public SimpleServiceClientChannel(System.ServiceModel.ClientBase<XamarinClient.ServiceReference1.ISimpleService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginSinkRequest(string request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("SinkRequest", _args, callback, asyncState);
                return _result;
            }
            
            public void EndSinkRequest(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("SinkRequest", _args, result);
            }
            
            public System.IAsyncResult BeginGetSimpleResponse(string request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetSimpleResponse", _args, callback, asyncState);
                return _result;
            }
            
            public XamarinClient.ServiceReference1.SimpleResponse EndGetSimpleResponse(System.IAsyncResult result) {
                object[] _args = new object[0];
                XamarinClient.ServiceReference1.SimpleResponse _result = ((XamarinClient.ServiceReference1.SimpleResponse)(base.EndInvoke("GetSimpleResponse", _args, result)));
                return _result;
            }
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_ISimpleService,
        }
    }
}
