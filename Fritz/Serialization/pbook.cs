﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.8.3928.0.
// 
namespace Fritz.Serialization {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class phonebooks {
        
        private phonebooksPhonebook[] itemsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("phonebook", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public phonebooksPhonebook[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class phonebooksPhonebook {
        
        private phonebooksPhonebookContact[] contactField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("contact", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public phonebooksPhonebookContact[] contact {
            get {
                return this.contactField;
            }
            set {
                this.contactField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class phonebooksPhonebookContact {
        
        private string categoryField;
        
        private string mod_timeField;
        
        private string uniqueidField;
        
        private phonebooksPhonebookContactPerson[] personField;
        
        private phonebooksPhonebookContactTelephony[] telephonyField;
        
        private phonebooksPhonebookContactServices[] servicesField;
        
        private phonebooksPhonebookContactSetup[] setupField;
        
        private phonebooksPhonebookContactFeatures[] featuresField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string mod_time {
            get {
                return this.mod_timeField;
            }
            set {
                this.mod_timeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string uniqueid {
            get {
                return this.uniqueidField;
            }
            set {
                this.uniqueidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("person", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public phonebooksPhonebookContactPerson[] person {
            get {
                return this.personField;
            }
            set {
                this.personField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telephony", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public phonebooksPhonebookContactTelephony[] telephony {
            get {
                return this.telephonyField;
            }
            set {
                this.telephonyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("services", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public phonebooksPhonebookContactServices[] services {
            get {
                return this.servicesField;
            }
            set {
                this.servicesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("setup", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public phonebooksPhonebookContactSetup[] setup {
            get {
                return this.setupField;
            }
            set {
                this.setupField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("features", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public phonebooksPhonebookContactFeatures[] features {
            get {
                return this.featuresField;
            }
            set {
                this.featuresField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class phonebooksPhonebookContactPerson {
        
        private string realNameField;
        
        private string imageURLField;
        
        private string imageURLField1;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string realName {
            get {
                return this.realNameField;
            }
            set {
                this.realNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ImageURL {
            get {
                return this.imageURLField;
            }
            set {
                this.imageURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string imageURL {
            get {
                return this.imageURLField1;
            }
            set {
                this.imageURLField1 = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class phonebooksPhonebookContactTelephony {
        
        private phonebooksPhonebookContactTelephonyNumber[] numberField;
        
        private string nidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("number", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public phonebooksPhonebookContactTelephonyNumber[] number {
            get {
                return this.numberField;
            }
            set {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nid {
            get {
                return this.nidField;
            }
            set {
                this.nidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class phonebooksPhonebookContactTelephonyNumber {
        
        private string typeField;
        
        private string quickdialField;
        
        private string vanityField;
        
        private string prioField;
        
        private string idField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quickdial {
            get {
                return this.quickdialField;
            }
            set {
                this.quickdialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string vanity {
            get {
                return this.vanityField;
            }
            set {
                this.vanityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string prio {
            get {
                return this.prioField;
            }
            set {
                this.prioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class phonebooksPhonebookContactServices {
        
        private phonebooksPhonebookContactServicesEmail[] emailField;
        
        private string nidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("email", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public phonebooksPhonebookContactServicesEmail[] email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nid {
            get {
                return this.nidField;
            }
            set {
                this.nidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class phonebooksPhonebookContactServicesEmail {
        
        private string classifierField;
        
        private string idField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string classifier {
            get {
                return this.classifierField;
            }
            set {
                this.classifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class phonebooksPhonebookContactSetup {
        
        private string ringToneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string ringTone {
            get {
                return this.ringToneField;
            }
            set {
                this.ringToneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class phonebooksPhonebookContactFeatures {
        
        private string doorphoneField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string doorphone {
            get {
                return this.doorphoneField;
            }
            set {
                this.doorphoneField = value;
            }
        }
    }
}