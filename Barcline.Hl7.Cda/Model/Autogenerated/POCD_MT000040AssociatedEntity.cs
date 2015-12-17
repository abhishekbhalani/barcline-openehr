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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="POCD_MT000040.AssociatedEntity", Namespace="urn:hl7-org:v3")]
    public partial class POCD_MT000040AssociatedEntity : CdaObject, System.ComponentModel.INotifyPropertyChanged
    {
        
        private CSCollection realmCodeField;
        
        private POCD_MT000040InfrastructureRoottypeId typeIdField;
        
        private IICollection templateIdField;
        
        private IICollection idField;
        
        private CE codeField;
        
        private ADCollection addrField;
        
        private TELCollection telecomField;
        
        private POCD_MT000040Person associatedPersonField;
        
        private POCD_MT000040Organization scopingOrganizationField;
        
        private string nullFlavorField;
        
        private string classCodeField;
        
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
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual CE code
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
        [System.Xml.Serialization.XmlElementAttribute("addr")]
        public virtual ADCollection addr
        {
            get
            {
                if (addrField == null)
                {
                    this.addrField = new ADCollection();
                }
                return addrField;
            }
            set
            {
                this.addrField = value;
                this.RaisePropertyChanged("addr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("telecom")]
        public virtual TELCollection telecom
        {
            get
            {
                if (telecomField == null)
                {
                    this.telecomField = new TELCollection();
                }
                return telecomField;
            }
            set
            {
                this.telecomField = value;
                this.RaisePropertyChanged("telecom");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual POCD_MT000040Person associatedPerson
        {
            get
            {
                return associatedPersonField;
            }
            set
            {
                this.associatedPersonField = value;
                this.RaisePropertyChanged("associatedPerson");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual POCD_MT000040Organization scopingOrganization
        {
            get
            {
                return scopingOrganizationField;
            }
            set
            {
                this.scopingOrganizationField = value;
                this.RaisePropertyChanged("scopingOrganization");
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
