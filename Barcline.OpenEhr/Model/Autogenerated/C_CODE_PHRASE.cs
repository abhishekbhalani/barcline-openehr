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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_CODE_REFERENCE))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("C_CODE_PHRASE", Schema = "openehr")]
    public partial class C_CODE_PHRASE : C_DOMAIN_TYPE
    {
        
        private CODE_PHRASE assumed_valueField;
        
        private TERMINOLOGY_ID terminology_idField;
        
        private string[] code_listField;
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual CODE_PHRASE assumed_value
        {
            get
            {
                return assumed_valueField;
            }
            set
            {
                this.assumed_valueField = value;
                this.RaisePropertyChanged("assumed_value");
            }
        }
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual TERMINOLOGY_ID terminology_id
        {
            get
            {
                return terminology_idField;
            }
            set
            {
                this.terminology_idField = value;
                this.RaisePropertyChanged("terminology_id");
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("code_list")]
        public virtual string[] code_list
        {
            get
            {
                return this.code_listField;
            }
            set
            {
                this.code_listField = value;
                this.RaisePropertyChanged("code_list");
            }
        }
    }
}