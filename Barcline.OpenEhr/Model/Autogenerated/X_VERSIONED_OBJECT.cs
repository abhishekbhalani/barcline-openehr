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
    /// Required properties: extract_version_count, owner_id, time_created, total_version_count, uid
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute("versioned_object", Namespace="http://schemas.openehr.org/v1", IsNullable=false)]
    [Table("X_VERSIONED_OBJECT", Schema = "openehr")]
    public partial class X_VERSIONED_OBJECT : System.ComponentModel.INotifyPropertyChanged
    {
        
        private HIER_OBJECT_ID uidField;
        
        private OBJECT_REF owner_idField;
        
        private DV_DATE_TIME time_createdField;
        
        private int total_version_countField;
        
        private int extract_version_countField;
        
        private REVISION_HISTORY_ITEMCollection revision_historyField;
        
        private ORIGINAL_VERSIONCollection versionsField;

        [Key]
        [Required]
        [MaxLength(4000)]
        public string uid_value { get; set; }

        [Required]
        [ForeignKey("uid_value")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual HIER_OBJECT_ID uid
        {
            get
            {
                return uidField;
            }
            set
            {
                this.uidField = value;
                this.RaisePropertyChanged("uid");
            }
        }
        
        [Required()]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual OBJECT_REF owner_id
        {
            get
            {
                return owner_idField;
            }
            set
            {
                this.owner_idField = value;
                this.RaisePropertyChanged("owner_id");
            }
        }
        
        [Required()]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual DV_DATE_TIME time_created
        {
            get
            {
                return time_createdField;
            }
            set
            {
                this.time_createdField = value;
                this.RaisePropertyChanged("time_created");
            }
        }
        
        [Required()]
        public virtual int total_version_count
        {
            get
            {
                return this.total_version_countField;
            }
            set
            {
                this.total_version_countField = value;
                this.RaisePropertyChanged("total_version_count");
            }
        }
        
        [Required()]
        public virtual int extract_version_count
        {
            get
            {
                return this.extract_version_countField;
            }
            set
            {
                this.extract_version_countField = value;
                this.RaisePropertyChanged("extract_version_count");
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("items", IsNullable=false)]
        [Barcline.Core.MinOccurs("0")]
        public virtual REVISION_HISTORY_ITEMCollection revision_history
        {
            get
            {
                if (revision_historyField == null)
                {
                    this.revision_historyField = new REVISION_HISTORY_ITEMCollection();
                }
                return revision_historyField;
            }
            set
            {
                this.revision_historyField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("revision_history");
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("versions")]
        [Barcline.Core.MinOccurs("0")]
        [Barcline.Core.MaxOccurs("unbounded")]
        public virtual ORIGINAL_VERSIONCollection versions
        {
            get
            {
                if (versionsField == null)
                {
                    this.versionsField = new ORIGINAL_VERSIONCollection();
                }
                return versionsField;
            }
            set
            {
                this.versionsField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("versions");
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
