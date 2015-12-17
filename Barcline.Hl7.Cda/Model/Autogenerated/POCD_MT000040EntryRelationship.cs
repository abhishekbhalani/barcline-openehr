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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="POCD_MT000040.EntryRelationship", Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute("POCD_MT000040.EntryRelationship", Namespace="urn:hl7-org:v3", IsNullable=true)]
    public partial class POCD_MT000040EntryRelationship : CdaObject, System.ComponentModel.INotifyPropertyChanged
    {
        
        private CSCollection realmCodeField;
        
        private POCD_MT000040InfrastructureRoottypeId typeIdField;
        
        private IICollection templateIdField;
        
        private INT sequenceNumberField;
        
        private BL seperatableIndField;
        
        private object itemField;
        
        private string nullFlavorField;
        
        private x_ActRelationshipEntryRelationship typeCodeField;
        
        private bool inversionIndField;
        
        private bool inversionIndFieldSpecified;
        
        private bool contextConductionIndField;
        
        private bool negationIndField;
        
        private bool negationIndFieldSpecified;
        
        public POCD_MT000040EntryRelationship()
        {
            this.contextConductionIndField = true;
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
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual INT sequenceNumber
        {
            get
            {
                return sequenceNumberField;
            }
            set
            {
                this.sequenceNumberField = value;
                this.RaisePropertyChanged("sequenceNumber");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual BL seperatableInd
        {
            get
            {
                return seperatableIndField;
            }
            set
            {
                this.seperatableIndField = value;
                this.RaisePropertyChanged("seperatableInd");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("act", typeof(POCD_MT000040Act))]
        [System.Xml.Serialization.XmlElementAttribute("encounter", typeof(POCD_MT000040Encounter))]
        [System.Xml.Serialization.XmlElementAttribute("observation", typeof(POCD_MT000040Observation))]
        [System.Xml.Serialization.XmlElementAttribute("observationMedia", typeof(POCD_MT000040ObservationMedia))]
        [System.Xml.Serialization.XmlElementAttribute("organizer", typeof(POCD_MT000040Organizer))]
        [System.Xml.Serialization.XmlElementAttribute("procedure", typeof(POCD_MT000040Procedure))]
        [System.Xml.Serialization.XmlElementAttribute("regionOfInterest", typeof(POCD_MT000040RegionOfInterest))]
        [System.Xml.Serialization.XmlElementAttribute("substanceAdministration", typeof(POCD_MT000040SubstanceAdministration))]
        [System.Xml.Serialization.XmlElementAttribute("supply", typeof(POCD_MT000040Supply))]
        public virtual object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("Item");
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
        public virtual x_ActRelationshipEntryRelationship typeCode
        {
            get
            {
                return typeCodeField;
            }
            set
            {
                this.typeCodeField = value;
                this.RaisePropertyChanged("typeCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual bool inversionInd
        {
            get
            {
                return this.inversionIndField;
            }
            set
            {
                this.inversionIndField = value;
                this.RaisePropertyChanged("inversionInd");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool inversionIndSpecified
        {
            get
            {
                return this.inversionIndFieldSpecified;
            }
            set
            {
                this.inversionIndFieldSpecified = value;
                this.RaisePropertyChanged("inversionIndSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public virtual bool contextConductionInd
        {
            get
            {
                return this.contextConductionIndField;
            }
            set
            {
                this.contextConductionIndField = value;
                this.RaisePropertyChanged("contextConductionInd");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual bool negationInd
        {
            get
            {
                return this.negationIndField;
            }
            set
            {
                this.negationIndField = value;
                this.RaisePropertyChanged("negationInd");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool negationIndSpecified
        {
            get
            {
                return this.negationIndFieldSpecified;
            }
            set
            {
                this.negationIndFieldSpecified = value;
                this.RaisePropertyChanged("negationIndSpecified");
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