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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_GENERAL_TIME_SPECIFICATION))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_PERIODIC_TIME_SPECIFICATION))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("DV_TIME_SPECIFICATION", Schema = "openehr")]
    public abstract partial class DV_TIME_SPECIFICATION : DATA_VALUE
    {
        
        private DV_PARSABLE valueField;
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual DV_PARSABLE value
        {
            get
            {
                return valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }
    }
}