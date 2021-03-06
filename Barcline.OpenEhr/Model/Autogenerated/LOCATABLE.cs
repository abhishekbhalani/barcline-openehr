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
    using System.Runtime.Serialization;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    /// <summary>
    /// Required properties: name
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ADDRESS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CONTACT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CAPABILITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PARTY_RELATIONSHIP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PARTY_IDENTITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PARTY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACTOR))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ORGANISATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AGENT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GROUP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PERSON))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ROLE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FOLDER))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EXTRACT_REQUEST))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EXTRACT_FOLDER))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EXTRACT_CHAPTER))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EXTRACT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACTIVITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EVENT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(INTERVAL_EVENT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(POINT_EVENT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HISTORY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ITEM))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ELEMENT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CLUSTER))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ITEM_STRUCTURE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ITEM_TABLE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ITEM_TREE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ITEM_LIST))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ITEM_SINGLE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CONTENT_ITEM))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ENTRY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CARE_ENTRY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ACTION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(INSTRUCTION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OBSERVATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EVALUATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ADMIN_ENTRY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GENERIC_ENTRY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SECTION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(COMPOSITION))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute("items", Namespace="http://schemas.openehr.org/v1", IsNullable=false)]
    [Table("LOCATABLE", Schema = "openehr")]
    public abstract partial class LOCATABLE : OpenEhrUuidBasedObject, System.ComponentModel.INotifyPropertyChanged
    {
        
        private DV_TEXT nameField;
        
        private UID_BASED_ID uidField;
        
        private LINKCollection linksField;
        
        private ARCHETYPED archetype_detailsField;
        
        private FEEDER_AUDIT feeder_auditField;
        
        private string archetype_node_idField;
        
        [Required()]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual DV_TEXT name
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

        [Index("C_LOCATABLE_UID_UK", IsUnique=true)]
        public string uid_value { get; set; }
        
        [Barcline.Core.MinOccurs("0")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        [ForeignKey("uid_value")]
        public virtual UID_BASED_ID uid
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
        
        [System.Xml.Serialization.XmlElementAttribute("links")]
        [Barcline.Core.MinOccurs("0")]
        [Barcline.Core.MaxOccurs("unbounded")]
        public virtual LINKCollection links
        {
            get
            {
                if (linksField == null)
                {
                    this.linksField = new LINKCollection();
                }
                return linksField;
            }
            set
            {
                this.linksField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("links");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [Barcline.Core.MaxOccurs("1")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual ARCHETYPED archetype_details
        {
            get
            {
                return archetype_detailsField;
            }
            set
            {
                this.archetype_detailsField = value;
                this.RaisePropertyChanged("archetype_details");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual FEEDER_AUDIT feeder_audit
        {
            get
            {
                return feeder_auditField;
            }
            set
            {
                this.feeder_auditField = value;
                this.RaisePropertyChanged("feeder_audit");
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [MaxLength(4000)]
        public virtual string archetype_node_id
        {
            get
            {
                return this.archetype_node_idField;
            }
            set
            {
                this.archetype_node_idField = value;
                this.RaisePropertyChanged("archetype_node_id");
            }
        }
        
        [field:NonSerialized]
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
