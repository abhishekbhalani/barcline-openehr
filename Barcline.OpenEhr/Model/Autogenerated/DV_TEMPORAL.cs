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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DATE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_TIME))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DV_DATE_TIME))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("DV_TEMPORAL", Schema = "openehr")]
    public partial class DV_TEMPORAL : DV_QUANTIFIED
    {
        
        private DV_DURATION accuracyField;
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual DV_DURATION accuracy
        {
            get
            {
                return accuracyField;
            }
            set
            {
                this.accuracyField = value;
                this.RaisePropertyChanged("accuracy");
            }
        }
    }
}
