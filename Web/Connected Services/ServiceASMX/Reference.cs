﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.ServiceASMX {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductoDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ProductoDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        private decimal PrecioField;
        
        private System.Nullable<int> IdMarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.ServiceASMX.MarcaDTO MarcaField;
        
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
        public int IdProducto {
            get {
                return this.IdProductoField;
            }
            set {
                if ((this.IdProductoField.Equals(value) != true)) {
                    this.IdProductoField = value;
                    this.RaisePropertyChanged("IdProducto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public decimal Precio {
            get {
                return this.PrecioField;
            }
            set {
                if ((this.PrecioField.Equals(value) != true)) {
                    this.PrecioField = value;
                    this.RaisePropertyChanged("Precio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.Nullable<int> IdMarca {
            get {
                return this.IdMarcaField;
            }
            set {
                if ((this.IdMarcaField.Equals(value) != true)) {
                    this.IdMarcaField = value;
                    this.RaisePropertyChanged("IdMarca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public Web.ServiceASMX.MarcaDTO Marca {
            get {
                return this.MarcaField;
            }
            set {
                if ((object.ReferenceEquals(this.MarcaField, value) != true)) {
                    this.MarcaField = value;
                    this.RaisePropertyChanged("Marca");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="MarcaDTO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class MarcaDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdMarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Web.ServiceASMX.ProductoDTO[] ProductoField;
        
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
        public int IdMarca {
            get {
                return this.IdMarcaField;
            }
            set {
                if ((this.IdMarcaField.Equals(value) != true)) {
                    this.IdMarcaField = value;
                    this.RaisePropertyChanged("IdMarca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public Web.ServiceASMX.ProductoDTO[] Producto {
            get {
                return this.ProductoField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductoField, value) != true)) {
                    this.ProductoField = value;
                    this.RaisePropertyChanged("Producto");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceASMX.ProductosSoap")]
    public interface ProductosSoap {
        
        // CODEGEN: Generating message contract since element name ObtenerTodosResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerTodos", ReplyAction="*")]
        Web.ServiceASMX.ObtenerTodosResponse ObtenerTodos(Web.ServiceASMX.ObtenerTodosRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerTodos", ReplyAction="*")]
        System.Threading.Tasks.Task<Web.ServiceASMX.ObtenerTodosResponse> ObtenerTodosAsync(Web.ServiceASMX.ObtenerTodosRequest request);
        
        // CODEGEN: Generating message contract since element name ObtenerPorIdResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerPorId", ReplyAction="*")]
        Web.ServiceASMX.ObtenerPorIdResponse ObtenerPorId(Web.ServiceASMX.ObtenerPorIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ObtenerPorId", ReplyAction="*")]
        System.Threading.Tasks.Task<Web.ServiceASMX.ObtenerPorIdResponse> ObtenerPorIdAsync(Web.ServiceASMX.ObtenerPorIdRequest request);
        
        // CODEGEN: Generating message contract since element name prod from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Crear", ReplyAction="*")]
        Web.ServiceASMX.CrearResponse Crear(Web.ServiceASMX.CrearRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Crear", ReplyAction="*")]
        System.Threading.Tasks.Task<Web.ServiceASMX.CrearResponse> CrearAsync(Web.ServiceASMX.CrearRequest request);
        
        // CODEGEN: Generating message contract since element name prod from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Modificar", ReplyAction="*")]
        Web.ServiceASMX.ModificarResponse Modificar(Web.ServiceASMX.ModificarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Modificar", ReplyAction="*")]
        System.Threading.Tasks.Task<Web.ServiceASMX.ModificarResponse> ModificarAsync(Web.ServiceASMX.ModificarRequest request);
        
        // CODEGEN: Generating message contract since element name prod from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        Web.ServiceASMX.EliminarResponse Eliminar(Web.ServiceASMX.EliminarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<Web.ServiceASMX.EliminarResponse> EliminarAsync(Web.ServiceASMX.EliminarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerTodosRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerTodos", Namespace="http://tempuri.org/", Order=0)]
        public Web.ServiceASMX.ObtenerTodosRequestBody Body;
        
        public ObtenerTodosRequest() {
        }
        
        public ObtenerTodosRequest(Web.ServiceASMX.ObtenerTodosRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ObtenerTodosRequestBody {
        
        public ObtenerTodosRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerTodosResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerTodosResponse", Namespace="http://tempuri.org/", Order=0)]
        public Web.ServiceASMX.ObtenerTodosResponseBody Body;
        
        public ObtenerTodosResponse() {
        }
        
        public ObtenerTodosResponse(Web.ServiceASMX.ObtenerTodosResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerTodosResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Web.ServiceASMX.ProductoDTO[] ObtenerTodosResult;
        
        public ObtenerTodosResponseBody() {
        }
        
        public ObtenerTodosResponseBody(Web.ServiceASMX.ProductoDTO[] ObtenerTodosResult) {
            this.ObtenerTodosResult = ObtenerTodosResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerPorIdRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerPorId", Namespace="http://tempuri.org/", Order=0)]
        public Web.ServiceASMX.ObtenerPorIdRequestBody Body;
        
        public ObtenerPorIdRequest() {
        }
        
        public ObtenerPorIdRequest(Web.ServiceASMX.ObtenerPorIdRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerPorIdRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public ObtenerPorIdRequestBody() {
        }
        
        public ObtenerPorIdRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ObtenerPorIdResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ObtenerPorIdResponse", Namespace="http://tempuri.org/", Order=0)]
        public Web.ServiceASMX.ObtenerPorIdResponseBody Body;
        
        public ObtenerPorIdResponse() {
        }
        
        public ObtenerPorIdResponse(Web.ServiceASMX.ObtenerPorIdResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ObtenerPorIdResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Web.ServiceASMX.ProductoDTO ObtenerPorIdResult;
        
        public ObtenerPorIdResponseBody() {
        }
        
        public ObtenerPorIdResponseBody(Web.ServiceASMX.ProductoDTO ObtenerPorIdResult) {
            this.ObtenerPorIdResult = ObtenerPorIdResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Crear", Namespace="http://tempuri.org/", Order=0)]
        public Web.ServiceASMX.CrearRequestBody Body;
        
        public CrearRequest() {
        }
        
        public CrearRequest(Web.ServiceASMX.CrearRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CrearRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Web.ServiceASMX.ProductoDTO prod;
        
        public CrearRequestBody() {
        }
        
        public CrearRequestBody(Web.ServiceASMX.ProductoDTO prod) {
            this.prod = prod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CrearResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CrearResponse", Namespace="http://tempuri.org/", Order=0)]
        public Web.ServiceASMX.CrearResponseBody Body;
        
        public CrearResponse() {
        }
        
        public CrearResponse(Web.ServiceASMX.CrearResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CrearResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CrearResult;
        
        public CrearResponseBody() {
        }
        
        public CrearResponseBody(string CrearResult) {
            this.CrearResult = CrearResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Modificar", Namespace="http://tempuri.org/", Order=0)]
        public Web.ServiceASMX.ModificarRequestBody Body;
        
        public ModificarRequest() {
        }
        
        public ModificarRequest(Web.ServiceASMX.ModificarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Web.ServiceASMX.ProductoDTO prod;
        
        public ModificarRequestBody() {
        }
        
        public ModificarRequestBody(Web.ServiceASMX.ProductoDTO prod) {
            this.prod = prod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ModificarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ModificarResponse", Namespace="http://tempuri.org/", Order=0)]
        public Web.ServiceASMX.ModificarResponseBody Body;
        
        public ModificarResponse() {
        }
        
        public ModificarResponse(Web.ServiceASMX.ModificarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ModificarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ModificarResult;
        
        public ModificarResponseBody() {
        }
        
        public ModificarResponseBody(string ModificarResult) {
            this.ModificarResult = ModificarResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Eliminar", Namespace="http://tempuri.org/", Order=0)]
        public Web.ServiceASMX.EliminarRequestBody Body;
        
        public EliminarRequest() {
        }
        
        public EliminarRequest(Web.ServiceASMX.EliminarRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Web.ServiceASMX.ProductoDTO prod;
        
        public EliminarRequestBody() {
        }
        
        public EliminarRequestBody(Web.ServiceASMX.ProductoDTO prod) {
            this.prod = prod;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EliminarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EliminarResponse", Namespace="http://tempuri.org/", Order=0)]
        public Web.ServiceASMX.EliminarResponseBody Body;
        
        public EliminarResponse() {
        }
        
        public EliminarResponse(Web.ServiceASMX.EliminarResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EliminarResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string EliminarResult;
        
        public EliminarResponseBody() {
        }
        
        public EliminarResponseBody(string EliminarResult) {
            this.EliminarResult = EliminarResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProductosSoapChannel : Web.ServiceASMX.ProductosSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProductosSoapClient : System.ServiceModel.ClientBase<Web.ServiceASMX.ProductosSoap>, Web.ServiceASMX.ProductosSoap {
        
        public ProductosSoapClient() {
        }
        
        public ProductosSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProductosSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductosSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProductosSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceASMX.ObtenerTodosResponse Web.ServiceASMX.ProductosSoap.ObtenerTodos(Web.ServiceASMX.ObtenerTodosRequest request) {
            return base.Channel.ObtenerTodos(request);
        }
        
        public Web.ServiceASMX.ProductoDTO[] ObtenerTodos() {
            Web.ServiceASMX.ObtenerTodosRequest inValue = new Web.ServiceASMX.ObtenerTodosRequest();
            inValue.Body = new Web.ServiceASMX.ObtenerTodosRequestBody();
            Web.ServiceASMX.ObtenerTodosResponse retVal = ((Web.ServiceASMX.ProductosSoap)(this)).ObtenerTodos(inValue);
            return retVal.Body.ObtenerTodosResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceASMX.ObtenerTodosResponse> Web.ServiceASMX.ProductosSoap.ObtenerTodosAsync(Web.ServiceASMX.ObtenerTodosRequest request) {
            return base.Channel.ObtenerTodosAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceASMX.ObtenerTodosResponse> ObtenerTodosAsync() {
            Web.ServiceASMX.ObtenerTodosRequest inValue = new Web.ServiceASMX.ObtenerTodosRequest();
            inValue.Body = new Web.ServiceASMX.ObtenerTodosRequestBody();
            return ((Web.ServiceASMX.ProductosSoap)(this)).ObtenerTodosAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceASMX.ObtenerPorIdResponse Web.ServiceASMX.ProductosSoap.ObtenerPorId(Web.ServiceASMX.ObtenerPorIdRequest request) {
            return base.Channel.ObtenerPorId(request);
        }
        
        public Web.ServiceASMX.ProductoDTO ObtenerPorId(int id) {
            Web.ServiceASMX.ObtenerPorIdRequest inValue = new Web.ServiceASMX.ObtenerPorIdRequest();
            inValue.Body = new Web.ServiceASMX.ObtenerPorIdRequestBody();
            inValue.Body.id = id;
            Web.ServiceASMX.ObtenerPorIdResponse retVal = ((Web.ServiceASMX.ProductosSoap)(this)).ObtenerPorId(inValue);
            return retVal.Body.ObtenerPorIdResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceASMX.ObtenerPorIdResponse> Web.ServiceASMX.ProductosSoap.ObtenerPorIdAsync(Web.ServiceASMX.ObtenerPorIdRequest request) {
            return base.Channel.ObtenerPorIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceASMX.ObtenerPorIdResponse> ObtenerPorIdAsync(int id) {
            Web.ServiceASMX.ObtenerPorIdRequest inValue = new Web.ServiceASMX.ObtenerPorIdRequest();
            inValue.Body = new Web.ServiceASMX.ObtenerPorIdRequestBody();
            inValue.Body.id = id;
            return ((Web.ServiceASMX.ProductosSoap)(this)).ObtenerPorIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceASMX.CrearResponse Web.ServiceASMX.ProductosSoap.Crear(Web.ServiceASMX.CrearRequest request) {
            return base.Channel.Crear(request);
        }
        
        public string Crear(Web.ServiceASMX.ProductoDTO prod) {
            Web.ServiceASMX.CrearRequest inValue = new Web.ServiceASMX.CrearRequest();
            inValue.Body = new Web.ServiceASMX.CrearRequestBody();
            inValue.Body.prod = prod;
            Web.ServiceASMX.CrearResponse retVal = ((Web.ServiceASMX.ProductosSoap)(this)).Crear(inValue);
            return retVal.Body.CrearResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceASMX.CrearResponse> Web.ServiceASMX.ProductosSoap.CrearAsync(Web.ServiceASMX.CrearRequest request) {
            return base.Channel.CrearAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceASMX.CrearResponse> CrearAsync(Web.ServiceASMX.ProductoDTO prod) {
            Web.ServiceASMX.CrearRequest inValue = new Web.ServiceASMX.CrearRequest();
            inValue.Body = new Web.ServiceASMX.CrearRequestBody();
            inValue.Body.prod = prod;
            return ((Web.ServiceASMX.ProductosSoap)(this)).CrearAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceASMX.ModificarResponse Web.ServiceASMX.ProductosSoap.Modificar(Web.ServiceASMX.ModificarRequest request) {
            return base.Channel.Modificar(request);
        }
        
        public string Modificar(Web.ServiceASMX.ProductoDTO prod) {
            Web.ServiceASMX.ModificarRequest inValue = new Web.ServiceASMX.ModificarRequest();
            inValue.Body = new Web.ServiceASMX.ModificarRequestBody();
            inValue.Body.prod = prod;
            Web.ServiceASMX.ModificarResponse retVal = ((Web.ServiceASMX.ProductosSoap)(this)).Modificar(inValue);
            return retVal.Body.ModificarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceASMX.ModificarResponse> Web.ServiceASMX.ProductosSoap.ModificarAsync(Web.ServiceASMX.ModificarRequest request) {
            return base.Channel.ModificarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceASMX.ModificarResponse> ModificarAsync(Web.ServiceASMX.ProductoDTO prod) {
            Web.ServiceASMX.ModificarRequest inValue = new Web.ServiceASMX.ModificarRequest();
            inValue.Body = new Web.ServiceASMX.ModificarRequestBody();
            inValue.Body.prod = prod;
            return ((Web.ServiceASMX.ProductosSoap)(this)).ModificarAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Web.ServiceASMX.EliminarResponse Web.ServiceASMX.ProductosSoap.Eliminar(Web.ServiceASMX.EliminarRequest request) {
            return base.Channel.Eliminar(request);
        }
        
        public string Eliminar(Web.ServiceASMX.ProductoDTO prod) {
            Web.ServiceASMX.EliminarRequest inValue = new Web.ServiceASMX.EliminarRequest();
            inValue.Body = new Web.ServiceASMX.EliminarRequestBody();
            inValue.Body.prod = prod;
            Web.ServiceASMX.EliminarResponse retVal = ((Web.ServiceASMX.ProductosSoap)(this)).Eliminar(inValue);
            return retVal.Body.EliminarResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Web.ServiceASMX.EliminarResponse> Web.ServiceASMX.ProductosSoap.EliminarAsync(Web.ServiceASMX.EliminarRequest request) {
            return base.Channel.EliminarAsync(request);
        }
        
        public System.Threading.Tasks.Task<Web.ServiceASMX.EliminarResponse> EliminarAsync(Web.ServiceASMX.ProductoDTO prod) {
            Web.ServiceASMX.EliminarRequest inValue = new Web.ServiceASMX.EliminarRequest();
            inValue.Body = new Web.ServiceASMX.EliminarRequestBody();
            inValue.Body.prod = prod;
            return ((Web.ServiceASMX.ProductosSoap)(this)).EliminarAsync(inValue);
        }
    }
}
