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
    [Table("GENERIC_ID", Schema = "openehr")]
    public partial class GENERIC_ID : OBJECT_ID
    {
        
        private string schemeField;
        
        [MaxLength(4000)]
        public virtual string scheme
        {
            get
            {
                return this.schemeField;
            }
            set
            {
                this.schemeField = value;
                this.RaisePropertyChanged("scheme");
            }
        }
    }
}
