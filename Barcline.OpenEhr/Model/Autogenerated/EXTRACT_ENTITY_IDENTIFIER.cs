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
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("EXTRACT_ENTITY_IDENTIFIER", Schema = "openehr")]
    public partial class EXTRACT_ENTITY_IDENTIFIER : System.ComponentModel.INotifyPropertyChanged
    {
        
        private HIER_OBJECT_ID entity_idField;
        
        private PARTY_IDENTIFIED subjectField;
        
        [Barcline.Core.MinOccurs("0")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual HIER_OBJECT_ID entity_id
        {
            get
            {
                return entity_idField;
            }
            set
            {
                this.entity_idField = value;
                this.RaisePropertyChanged("entity_id");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual PARTY_IDENTIFIED subject
        {
            get
            {
                return subjectField;
            }
            set
            {
                this.subjectField = value;
                this.RaisePropertyChanged("subject");
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
