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
    [Table("IntervalOfDuration", Schema = "openehr")]
    public partial class IntervalOfDuration : Interval
    {
        
        private TimeSpan? lowerField;
        
        private TimeSpan? upperField;

        [System.Xml.Serialization.XmlElement(typeof(XmlTimeSpan))]
        public virtual TimeSpan? lower
        {
            get
            {
                return this.lowerField;
            }
            set
            {
                this.lowerField = value;
                this.RaisePropertyChanged("lower");
            }
        }

        [System.Xml.Serialization.XmlElement(typeof(XmlTimeSpan))]
        public virtual TimeSpan? upper
        {
            get
            {
                return this.upperField;
            }
            set
            {
                this.upperField = value;
                this.RaisePropertyChanged("upper");
            }
        }
    }
}
