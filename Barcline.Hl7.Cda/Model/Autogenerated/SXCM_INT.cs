//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barcline.Hl7.Cda
{
    using System;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_INT))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdShell", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    public partial class SXCM_INT : INT
    {
        
        private SetOperator operatorField;
        
        public SXCM_INT()
        {
            this.operatorField = SetOperator.I;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(SetOperator.I)]
        public virtual SetOperator @operator
        {
            get
            {
                return this.operatorField;
            }
            set
            {
                this.operatorField = value;
                this.RaisePropertyChanged("operator");
            }
        }
    }
}
