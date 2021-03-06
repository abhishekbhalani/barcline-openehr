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
    [Table("INTERVAL_EVENT", Schema = "openehr")]
    public partial class INTERVAL_EVENT : EVENT
    {
        
        private DV_DURATION widthField;
        
        private int sample_countField;
        
        private bool sample_countFieldSpecified;
        
        private DV_CODED_TEXT math_functionField;
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual DV_DURATION width
        {
            get
            {
                return widthField;
            }
            set
            {
                this.widthField = value;
                this.RaisePropertyChanged("width");
            }
        }
        
        public virtual int sample_count
        {
            get
            {
                return this.sample_countField;
            }
            set
            {
                this.sample_countField = value;
                this.RaisePropertyChanged("sample_count");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool sample_countSpecified
        {
            get
            {
                return this.sample_countFieldSpecified;
            }
            set
            {
                this.sample_countFieldSpecified = value;
                this.RaisePropertyChanged("sample_countSpecified");
            }
        }
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual DV_CODED_TEXT math_function
        {
            get
            {
                return math_functionField;
            }
            set
            {
                this.math_functionField = value;
                this.RaisePropertyChanged("math_function");
            }
        }
    }
}
