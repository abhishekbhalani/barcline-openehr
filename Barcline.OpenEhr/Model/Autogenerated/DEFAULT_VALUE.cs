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
    /// Required properties: path
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_DV_STATE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_DV_QUANTITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_DV_ORDINAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_CODE_PHRASE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_DURATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_TIME))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_DATE_TIME))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_DATE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_REAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_INTEGER))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_STRING))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DEFAULT_BOOLEAN))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("DEFAULT_VALUE", Schema = "openehr")]
    public abstract partial class DEFAULT_VALUE : System.ComponentModel.INotifyPropertyChanged
    {
        
        private string pathField;
        
        [Required()]
        [MaxLength(4000)]
        public virtual string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
                this.RaisePropertyChanged("path");
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
