//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barcline.Hl7.Cda
{
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdShell", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="POCD_MT000040.ExternalDocument", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("POCD_MT000040.ExternalDocument", Namespace="urn:hl7-org:v3", IsNullable=true)]
    public partial class POCD_MT000040ExternalDocument : CdaObject, System.ComponentModel.INotifyPropertyChanged
    {
        
        private CSCollection realmCodeField;
        
        private POCD_MT000040InfrastructureRoottypeId typeIdField;
        
        private IICollection templateIdField;
        
        private IICollection idField;
        
        private CD codeField;
        
        private ED textField;
        
        private II setIdField;
        
        private INT versionNumberField;
        
        private string nullFlavorField;
        
        private string classCodeField;
        
        private string moodCodeField;
        
        public POCD_MT000040ExternalDocument()
        {
            this.classCodeField = "DOC";
            this.moodCodeField = "EVN";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("realmCode")]
        public virtual CSCollection realmCode
        {
            get
            {
                if (realmCodeField == null)
                {
                    this.realmCodeField = new CSCollection();
                }
                return realmCodeField;
            }
            set
            {
                this.realmCodeField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("realmCode");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual POCD_MT000040InfrastructureRoottypeId typeId
        {
            get
            {
                return typeIdField;
            }
            set
            {
                this.typeIdField = value;
                this.RaisePropertyChanged("typeId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("templateId")]
        public virtual IICollection templateId
        {
            get
            {
                if (templateIdField == null)
                {
                    this.templateIdField = new IICollection();
                }
                return templateIdField;
            }
            set
            {
                this.templateIdField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("templateId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("id")]
        public virtual IICollection id
        {
            get
            {
                if (idField == null)
                {
                    this.idField = new IICollection();
                }
                return idField;
            }
            set
            {
                this.idField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual CD code
        {
            get
            {
                return codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual ED text
        {
            get
            {
                return textField;
            }
            set
            {
                this.textField = value;
                this.RaisePropertyChanged("text");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual II setId
        {
            get
            {
                return setIdField;
            }
            set
            {
                this.setIdField = value;
                this.RaisePropertyChanged("setId");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual INT versionNumber
        {
            get
            {
                return versionNumberField;
            }
            set
            {
                this.versionNumberField = value;
                this.RaisePropertyChanged("versionNumber");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string nullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
                this.RaisePropertyChanged("nullFlavor");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("DOC")]
        public virtual string classCode
        {
            get
            {
                return this.classCodeField;
            }
            set
            {
                this.classCodeField = value;
                this.RaisePropertyChanged("classCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string moodCode
        {
            get
            {
                return this.moodCodeField;
            }
            set
            {
                this.moodCodeField = value;
                this.RaisePropertyChanged("moodCode");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
