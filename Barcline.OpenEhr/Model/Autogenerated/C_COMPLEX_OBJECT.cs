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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(C_ARCHETYPE_ROOT))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("C_COMPLEX_OBJECT", Schema = "openehr")]
    public partial class C_COMPLEX_OBJECT : C_DEFINED_OBJECT
    {
        
        private C_ATTRIBUTECollection attributesField;
        
        [System.Xml.Serialization.XmlElementAttribute("attributes")]
        public virtual C_ATTRIBUTECollection attributes
        {
            get
            {
                if (attributesField == null)
                {
                    this.attributesField = new C_ATTRIBUTECollection();
                }
                return attributesField;
            }
            set
            {
                this.attributesField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("attributes");
            }
        }
    }
}
