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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdShell", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    public partial class IVL_PPD_TS : SXCM_PPD_TS
    {
        
        private QTY[] itemsField;
        
        private ItemsChoiceType3[] itemsElementNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("center", typeof(PPD_TS))]
        [System.Xml.Serialization.XmlElementAttribute("high", typeof(IVXB_PPD_TS))]
        [System.Xml.Serialization.XmlElementAttribute("low", typeof(IVXB_PPD_TS))]
        [System.Xml.Serialization.XmlElementAttribute("width", typeof(PPD_PQ))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public virtual QTY[] Items
        {
            get
            {
                if (itemsField == null)
                {
                    this.itemsField = new QTY[0];
                }
                return itemsField;
            }
            set
            {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual ItemsChoiceType3[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
                this.RaisePropertyChanged("ItemsElementName");
            }
        }
    }
}
