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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_ENCAPSULATED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_PARSABLE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_MULTIMEDIA))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_TIME_SPECIFICATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_GENERAL_TIME_SPECIFICATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_PERIODIC_TIME_SPECIFICATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_PARAGRAPH))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_INTERVAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_ORDERED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_ORDINAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_QUANTIFIED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_TEMPORAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DATE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_TIME))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DATE_TIME))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_AMOUNT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DURATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_PROPORTION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_QUANTITY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_COUNT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_URI))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_EHR_URI))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_TEXT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_CODED_TEXT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_STATE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_IDENTIFIER))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_BOOLEAN))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("DATA_VALUE", Schema = "openehr")]
    public abstract partial class DATA_VALUE : System.ComponentModel.INotifyPropertyChanged
    {

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
