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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ARCHETYPE_INTERNAL_REF))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CONSTRAINT_REF))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_DEFINED_OBJECT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_DOMAIN_TYPE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_DV_STATE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_DV_QUANTITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_DV_ORDINAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_CODE_PHRASE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_CODE_REFERENCE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_PRIMITIVE_OBJECT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_COMPLEX_OBJECT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_ARCHETYPE_ROOT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ARCHETYPE_SLOT))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("C_OBJECT", Schema = "openehr")]
    public abstract partial class C_OBJECT : ARCHETYPE_CONSTRAINT
    {
        
        private string rm_type_nameField;
        
        private IntervalOfInteger occurrencesField;
        
        private string node_idField;
        
        [MaxLength(4000)]
        public virtual string rm_type_name
        {
            get
            {
                return this.rm_type_nameField;
            }
            set
            {
                this.rm_type_nameField = value;
                this.RaisePropertyChanged("rm_type_name");
            }
        }
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual IntervalOfInteger occurrences
        {
            get
            {
                return occurrencesField;
            }
            set
            {
                this.occurrencesField = value;
                this.RaisePropertyChanged("occurrences");
            }
        }
        
        [MaxLength(4000)]
        public virtual string node_id
        {
            get
            {
                return this.node_idField;
            }
            set
            {
                this.node_idField = value;
                this.RaisePropertyChanged("node_id");
            }
        }
    }
}
