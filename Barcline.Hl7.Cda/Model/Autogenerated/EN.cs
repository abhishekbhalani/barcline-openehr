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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ON))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PN))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdShell", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    public partial class EN : ANY
    {
        
        private ENXPCollection itemsField;
        
        private IVL_TS validTimeField;
        
        private string[] textField;
        
        private string[] useField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("delimiter", typeof(endelimiter))]
        [System.Xml.Serialization.XmlElementAttribute("family", typeof(enfamily))]
        [System.Xml.Serialization.XmlElementAttribute("given", typeof(engiven))]
        [System.Xml.Serialization.XmlElementAttribute("prefix", typeof(enprefix))]
        [System.Xml.Serialization.XmlElementAttribute("suffix", typeof(ensuffix))]
        public virtual ENXPCollection Items
        {
            get
            {
                if (itemsField == null)
                {
                    this.itemsField = new ENXPCollection();
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
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual IVL_TS validTime
        {
            get
            {
                return validTimeField;
            }
            set
            {
                this.validTimeField = value;
                this.RaisePropertyChanged("validTime");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public virtual string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
                this.RaisePropertyChanged("Text");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string[] use
        {
            get
            {
                return this.useField;
            }
            set
            {
                this.useField = value;
                this.RaisePropertyChanged("use");
            }
        }
    }
}
