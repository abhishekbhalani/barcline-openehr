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
    /// Required properties: commit_audit, contribution
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IMPORTED_VERSION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ORIGINAL_VERSION))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute("version", Namespace="http://schemas.openehr.org/v1", IsNullable=false)]
    [Table("VERSION", Schema = "openehr")]
    public abstract partial class VERSION : System.ComponentModel.INotifyPropertyChanged
    {
        
        private OBJECT_REF contributionField;
        
        private AUDIT_DETAILS commit_auditField;
        
        private string signatureField;
        
        [Required()]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual OBJECT_REF contribution
        {
            get
            {
                return contributionField;
            }
            set
            {
                this.contributionField = value;
                this.RaisePropertyChanged("contribution");
            }
        }
        
        [Required()]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual AUDIT_DETAILS commit_audit
        {
            get
            {
                return commit_auditField;
            }
            set
            {
                this.commit_auditField = value;
                this.RaisePropertyChanged("commit_audit");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [MaxLength(4000)]
        public virtual string signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
                this.RaisePropertyChanged("signature");
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
