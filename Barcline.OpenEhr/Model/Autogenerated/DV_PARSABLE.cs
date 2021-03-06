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
    [Table("DV_PARSABLE", Schema = "openehr")]
    public partial class DV_PARSABLE : DV_ENCAPSULATED
    {
        
        private string valueField;
        
        private string formalismField;
        
        [MaxLength(4000)]
        public virtual string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }
        
        [MaxLength(4000)]
        public virtual string formalism
        {
            get
            {
                return this.formalismField;
            }
            set
            {
                this.formalismField = value;
                this.RaisePropertyChanged("formalism");
            }
        }
    }
}
