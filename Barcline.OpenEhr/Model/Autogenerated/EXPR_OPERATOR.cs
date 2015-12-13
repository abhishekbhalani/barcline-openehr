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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EXPR_BINARY_OPERATOR))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EXPR_UNARY_OPERATOR))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("EXPR_OPERATOR", Schema = "openehr")]
    public abstract partial class EXPR_OPERATOR : EXPR_ITEM
    {
        
        private OPERATOR_KIND operatorField;
        
        private bool precedence_overriddenField;
        
        public virtual OPERATOR_KIND @operator
        {
            get
            {
                return operatorField;
            }
            set
            {
                this.operatorField = value;
                this.RaisePropertyChanged("operator");
            }
        }
        
        public virtual bool precedence_overridden
        {
            get
            {
                return this.precedence_overriddenField;
            }
            set
            {
                this.precedence_overriddenField = value;
                this.RaisePropertyChanged("precedence_overridden");
            }
        }
    }
}