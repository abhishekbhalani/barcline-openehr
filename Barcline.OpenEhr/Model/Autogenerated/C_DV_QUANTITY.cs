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
    [Table("C_DV_QUANTITY", Schema = "openehr")]
    public partial class C_DV_QUANTITY : C_DOMAIN_TYPE
    {
        
        private DV_QUANTITY assumed_valueField;
        
        private CODE_PHRASE propertyField;
        
        private C_QUANTITY_ITEMCollection listField;
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual DV_QUANTITY assumed_value
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
        public virtual CODE_PHRASE property
        {
            get
            {
                return propertyField;
            }
            set
            {
                this.propertyField = value;
                this.RaisePropertyChanged("property");
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("list")]
        public virtual C_QUANTITY_ITEMCollection list
        {
            get
            {
                if (listField == null)
                {
                    this.listField = new C_QUANTITY_ITEMCollection();
                }
                return listField;
            }
            set
            {
                this.listField = value;
                this.RaisePropertyChanged("list");
            }
        }
    }
}
