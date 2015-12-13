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
    [Table("DV_INTERVAL", Schema = "openehr")]
    public partial class DV_INTERVAL : DATA_VALUE
    {
        
        private DV_ORDERED lowerField;
        
        private DV_ORDERED upperField;
        
        private bool lower_includedField;
        
        private bool lower_includedFieldSpecified;
        
        private bool upper_includedField;
        
        private bool upper_includedFieldSpecified;
        
        private bool lower_unboundedField;
        
        private bool upper_unboundedField;
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual DV_ORDERED lower
        {
            get
            {
                return lowerField;
            }
            set
            {
                this.lowerField = value;
                this.RaisePropertyChanged("lower");
            }
        }
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual DV_ORDERED upper
        {
            get
            {
                return upperField;
            }
            set
            {
                this.upperField = value;
                this.RaisePropertyChanged("upper");
            }
        }
        
        public virtual bool lower_included
        {
            get
            {
                return this.lower_includedField;
            }
            set
            {
                this.lower_includedField = value;
                this.RaisePropertyChanged("lower_included");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool lower_includedSpecified
        {
            get
            {
                return this.lower_includedFieldSpecified;
            }
            set
            {
                this.lower_includedFieldSpecified = value;
                this.RaisePropertyChanged("lower_includedSpecified");
            }
        }
        
        public virtual bool upper_included
        {
            get
            {
                return this.upper_includedField;
            }
            set
            {
                this.upper_includedField = value;
                this.RaisePropertyChanged("upper_included");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool upper_includedSpecified
        {
            get
            {
                return this.upper_includedFieldSpecified;
            }
            set
            {
                this.upper_includedFieldSpecified = value;
                this.RaisePropertyChanged("upper_includedSpecified");
            }
        }
        
        public virtual bool lower_unbounded
        {
            get
            {
                return this.lower_unboundedField;
            }
            set
            {
                this.lower_unboundedField = value;
                this.RaisePropertyChanged("lower_unbounded");
            }
        }
        
        public virtual bool upper_unbounded
        {
            get
            {
                return this.upper_unboundedField;
            }
            set
            {
                this.upper_unboundedField = value;
                this.RaisePropertyChanged("upper_unbounded");
            }
        }
    }
}
