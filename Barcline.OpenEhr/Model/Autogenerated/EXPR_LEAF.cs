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
    [Table("EXPR_LEAF", Schema = "openehr")]
    public partial class EXPR_LEAF : EXPR_ITEM
    {
        
        private object itemField;
        
        private string reference_typeField;
        
        public virtual object item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("item");
            }
        }
        
        [MaxLength(4000)]
        public virtual string reference_type
        {
            get
            {
                return this.reference_typeField;
            }
            set
            {
                this.reference_typeField = value;
                this.RaisePropertyChanged("reference_type");
            }
        }
    }
}
