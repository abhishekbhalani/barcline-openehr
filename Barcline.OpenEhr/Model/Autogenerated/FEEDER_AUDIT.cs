//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barcline.OpenEhr.Model
{
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    
    
    /// <remarks/>
    /// <summary>
    /// Required properties: originating_system_audit
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("FEEDER_AUDIT", Schema = "openehr")]
    public partial class FEEDER_AUDIT : System.ComponentModel.INotifyPropertyChanged
    {
        
        private DV_IDENTIFIERCollection originating_system_item_idsField;
        
        private DV_IDENTIFIERCollection feeder_system_item_idsField;
        
        private DV_ENCAPSULATED original_contentField;
        
        private FEEDER_AUDIT_DETAILS originating_system_auditField;
        
        private FEEDER_AUDIT_DETAILS feeder_system_auditField;
        
        [System.Xml.Serialization.XmlElementAttribute("originating_system_item_ids")]
        [Barcline.Core.MinOccurs("0")]
        [Barcline.Core.MaxOccurs("unbounded")]
        public virtual DV_IDENTIFIERCollection originating_system_item_ids
        {
            get
            {
                if (originating_system_item_idsField == null)
                {
                    this.originating_system_item_idsField = new DV_IDENTIFIERCollection();
                }
                return originating_system_item_idsField;
            }
            set
            {
                this.originating_system_item_idsField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("originating_system_item_ids");
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("feeder_system_item_ids")]
        [Barcline.Core.MinOccurs("0")]
        [Barcline.Core.MaxOccurs("unbounded")]
        public virtual DV_IDENTIFIERCollection feeder_system_item_ids
        {
            get
            {
                if (feeder_system_item_idsField == null)
                {
                    this.feeder_system_item_idsField = new DV_IDENTIFIERCollection();
                }
                return feeder_system_item_idsField;
            }
            set
            {
                this.feeder_system_item_idsField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("feeder_system_item_ids");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual DV_ENCAPSULATED original_content
        {
            get
            {
                return original_contentField;
            }
            set
            {
                this.original_contentField = value;
                this.RaisePropertyChanged("original_content");
            }
        }
        
        [Required()]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual FEEDER_AUDIT_DETAILS originating_system_audit
        {
            get
            {
                return originating_system_auditField;
            }
            set
            {
                this.originating_system_auditField = value;
                this.RaisePropertyChanged("originating_system_audit");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual FEEDER_AUDIT_DETAILS feeder_system_audit
        {
            get
            {
                return feeder_system_auditField;
            }
            set
            {
                this.feeder_system_auditField = value;
                this.RaisePropertyChanged("feeder_system_audit");
            }
        }

        [field: NonSerialized]
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
