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
    /// Required properties: entity_identifier
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("EXTRACT_ENTITY_MANIFEST", Schema = "openehr")]
    public partial class EXTRACT_ENTITY_MANIFEST : System.ComponentModel.INotifyPropertyChanged
    {
        
        private OBJECT_REFCollection item_listField;
        
        private EXTRACT_ENTITY_IDENTIFIER entity_identifierField;
        
        [System.Xml.Serialization.XmlElementAttribute("item_list")]
        [Barcline.Core.MinOccurs("0")]
        [Barcline.Core.MaxOccurs("unbounded")]
        public virtual OBJECT_REFCollection item_list
        {
            get
            {
                if (item_listField == null)
                {
                    this.item_listField = new OBJECT_REFCollection();
                }
                return item_listField;
            }
            set
            {
                this.item_listField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("item_list");
            }
        }
        
        [Required()]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual EXTRACT_ENTITY_IDENTIFIER entity_identifier
        {
            get
            {
                return entity_identifierField;
            }
            set
            {
                this.entity_identifierField = value;
                this.RaisePropertyChanged("entity_identifier");
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
