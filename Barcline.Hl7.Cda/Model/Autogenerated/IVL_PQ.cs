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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BXIT_IVL_PQ))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdShell", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:hl7-org:v3", IsNullable=true)]
    public partial class IVL_PQ : SXCM_PQ
    {
        
        private PQCollection itemsField;
        
        private ItemsChoiceType[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center", typeof(PQ))]
        [System.Xml.Serialization.XmlElementAttribute("high", typeof(IVXB_PQ))]
        [System.Xml.Serialization.XmlElementAttribute("low", typeof(IVXB_PQ))]
        [System.Xml.Serialization.XmlElementAttribute("width", typeof(PQ))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public virtual PQCollection Items
        {
            get
            {
                if (itemsField == null)
                {
                    this.itemsField = new PQCollection();
                }
                return itemsField;
            }
            set
            {
                this.itemsField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemsChoiceType[] ItemsElementName
        {
            set
            {
                this.itemsElementNameField = value;
                this.RaisePropertyChanged("ItemsElementName");
            }
        }
    }
}