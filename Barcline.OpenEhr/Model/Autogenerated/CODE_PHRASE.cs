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
    /// Required properties: code_string, terminology_id
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("CODE_PHRASE", Schema = "openehr")]
    public partial class CODE_PHRASE : System.ComponentModel.INotifyPropertyChanged
    {
        
        private TERMINOLOGY_ID terminology_idField;
        
        private string code_stringField;
        
        [Required]
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
        
        [Required()]
        [MaxLength(4000)]
        public virtual string code_string
        {
            get
            {
                return this.code_stringField;
            }
            set
            {
                this.code_stringField = value;
                this.RaisePropertyChanged("code_string");
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
