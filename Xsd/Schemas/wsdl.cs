﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Этот исходный код был создан с помощью xsd, версия=4.8.3928.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
[System.Xml.Serialization.XmlRootAttribute("definitions", Namespace="http://schemas.xmlsoap.org/wsdl/", IsNullable=false)]
public partial class tDefinitions : tExtensibleDocumented {
    
    private tImport[] importField;
    
    private tTypes[] typesField;
    
    private tMessage[] messageField;
    
    private tPortType[] portTypeField;
    
    private tBinding[] bindingField;
    
    private tService[] serviceField;
    
    private string targetNamespaceField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("import")]
    public tImport[] import {
        get {
            return this.importField;
        }
        set {
            this.importField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("types")]
    public tTypes[] types {
        get {
            return this.typesField;
        }
        set {
            this.typesField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("message")]
    public tMessage[] message {
        get {
            return this.messageField;
        }
        set {
            this.messageField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("portType")]
    public tPortType[] portType {
        get {
            return this.portTypeField;
        }
        set {
            this.portTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("binding")]
    public tBinding[] binding {
        get {
            return this.bindingField;
        }
        set {
            this.bindingField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("service")]
    public tService[] service {
        get {
            return this.serviceField;
        }
        set {
            this.serviceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string targetNamespace {
        get {
            return this.targetNamespaceField;
        }
        set {
            this.targetNamespaceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tImport : tExtensibleAttributesDocumented {
    
    private string namespaceField;
    
    private string locationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string @namespace {
        get {
            return this.namespaceField;
        }
        set {
            this.namespaceField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string location {
        get {
            return this.locationField;
        }
        set {
            this.locationField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tFault))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tParam))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tPortType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tPart))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tImport))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public abstract partial class tExtensibleAttributesDocumented : tDocumented {
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tExtensibleDocumented))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tOperation))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tPort))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tService))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tBindingOperationFault))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tBindingOperationMessage))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tBindingOperation))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tBinding))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tMessage))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tTypes))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tDefinitions))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tExtensibleAttributesDocumented))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tFault))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tParam))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tPortType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tPart))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tImport))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tDocumented {
    
    private tDocumentation documentationField;
    
    /// <remarks/>
    public tDocumentation documentation {
        get {
            return this.documentationField;
        }
        set {
            this.documentationField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tDocumentation {
    
    private System.Xml.XmlNode[] anyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlNode[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tOperation))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tPort))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tService))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tBindingOperationFault))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tBindingOperationMessage))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tBindingOperation))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tBinding))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tMessage))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tTypes))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(tDefinitions))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public abstract partial class tExtensibleDocumented : tDocumented {
    
    private System.Xml.XmlElement[] anyField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlElement[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tOperation : tExtensibleDocumented {
    
    private tExtensibleAttributesDocumented[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    private string nameField;
    
    private string parameterOrderField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("fault", typeof(tFault))]
    [System.Xml.Serialization.XmlElementAttribute("input", typeof(tParam))]
    [System.Xml.Serialization.XmlElementAttribute("output", typeof(tParam))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public tExtensibleAttributesDocumented[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
    public string parameterOrder {
        get {
            return this.parameterOrderField;
        }
        set {
            this.parameterOrderField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tFault : tExtensibleAttributesDocumented {
    
    private string nameField;
    
    private System.Xml.XmlQualifiedName messageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName message {
        get {
            return this.messageField;
        }
        set {
            this.messageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tParam : tExtensibleAttributesDocumented {
    
    private string nameField;
    
    private System.Xml.XmlQualifiedName messageField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName message {
        get {
            return this.messageField;
        }
        set {
            this.messageField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/", IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    fault,
    
    /// <remarks/>
    input,
    
    /// <remarks/>
    output,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tPort : tExtensibleDocumented {
    
    private string nameField;
    
    private System.Xml.XmlQualifiedName bindingField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName binding {
        get {
            return this.bindingField;
        }
        set {
            this.bindingField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tService : tExtensibleDocumented {
    
    private tPort[] portField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("port")]
    public tPort[] port {
        get {
            return this.portField;
        }
        set {
            this.portField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tBindingOperationFault : tExtensibleDocumented {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tBindingOperationMessage : tExtensibleDocumented {
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tBindingOperation : tExtensibleDocumented {
    
    private tBindingOperationMessage inputField;
    
    private tBindingOperationMessage outputField;
    
    private tBindingOperationFault[] faultField;
    
    private string nameField;
    
    /// <remarks/>
    public tBindingOperationMessage input {
        get {
            return this.inputField;
        }
        set {
            this.inputField = value;
        }
    }
    
    /// <remarks/>
    public tBindingOperationMessage output {
        get {
            return this.outputField;
        }
        set {
            this.outputField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("fault")]
    public tBindingOperationFault[] fault {
        get {
            return this.faultField;
        }
        set {
            this.faultField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tBinding : tExtensibleDocumented {
    
    private tBindingOperation[] operationField;
    
    private string nameField;
    
    private System.Xml.XmlQualifiedName typeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("operation")]
    public tBindingOperation[] operation {
        get {
            return this.operationField;
        }
        set {
            this.operationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tMessage : tExtensibleDocumented {
    
    private tPart[] partField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("part")]
    public tPart[] part {
        get {
            return this.partField;
        }
        set {
            this.partField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tPart : tExtensibleAttributesDocumented {
    
    private string nameField;
    
    private System.Xml.XmlQualifiedName elementField;
    
    private System.Xml.XmlQualifiedName typeField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName element {
        get {
            return this.elementField;
        }
        set {
            this.elementField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public System.Xml.XmlQualifiedName type {
        get {
            return this.typeField;
        }
        set {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tTypes : tExtensibleDocumented {
     
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.xmlsoap.org/wsdl/")]
public partial class tPortType : tExtensibleAttributesDocumented {
    
    private tOperation[] operationField;
    
    private string nameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("operation")]
    public tOperation[] operation {
        get {
            return this.operationField;
        }
        set {
            this.operationField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NCName")]
    public string name {
        get {
            return this.nameField;
        }
        set {
            this.nameField = value;
        }
    }
}