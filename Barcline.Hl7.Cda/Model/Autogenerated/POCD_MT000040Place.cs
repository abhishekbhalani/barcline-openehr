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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="POCD_MT000040.Place", Namespace="urn:hl7-org:v3")]
    public partial class POCD_MT000040Place : CdaObject, System.ComponentModel.INotifyPropertyChanged
    {
        
        private CSCollection realmCodeField;
        
        private POCD_MT000040InfrastructureRoottypeId typeIdField;
        
        private IICollection templateIdField;
        
        private EN nameField;
        
        private AD addrField;
        
        private string nullFlavorField;
        
        private EntityClassPlace classCodeField;
        
        private bool classCodeFieldSpecified;
        
        private string determinerCodeField;
        
        public POCD_MT000040Place()
        {
            this.classCodeField = EntityClassPlace.PLC;
            this.determinerCodeField = "INSTANCE";
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
                this.RaisePropertyChanged("templateId");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual EN name
        {
            get
            {
                return nameField;
            }
            set
            {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual AD addr
        {
            get
            {
                return addrField;
            }
            set
            {
                this.addrField = value;
                this.RaisePropertyChanged("addr");
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
        public virtual EntityClassPlace classCode
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool classCodeSpecified
        {
            get
            {
                return this.classCodeFieldSpecified;
            }
            set
            {
                this.classCodeFieldSpecified = value;
                this.RaisePropertyChanged("classCodeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string determinerCode
        {
            get
            {
                return this.determinerCodeField;
            }
            set
            {
                this.determinerCodeField = value;
                this.RaisePropertyChanged("determinerCode");
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
