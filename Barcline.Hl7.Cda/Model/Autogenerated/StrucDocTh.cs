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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="StrucDoc.Th", Namespace="urn:hl7-org:v3")]
    public partial class StrucDocTh : CdaObject, System.ComponentModel.INotifyPropertyChanged
    {
        
        private object[] itemsField;
        
        private string[] textField;
        
        private string idField;
        
        private string languageField;
        
        private string styleCodeField;
        
        private string abbrField;
        
        private string axisField;
        
        private string headersField;
        
        private StrucDocThScope scopeField;
        
        private bool scopeFieldSpecified;
        
        private string rowspanField;
        
        private string colspanField;
        
        private StrucDocThAlign alignField;
        
        private bool alignFieldSpecified;
        
        private string charField;
        
        private string charoffField;
        
        private StrucDocThValign valignField;
        
        private bool valignFieldSpecified;
        
        public StrucDocTh()
        {
            this.rowspanField = "1";
            this.colspanField = "1";
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("br", typeof(StrucDocBr))]
        [System.Xml.Serialization.XmlElementAttribute("content", typeof(StrucDocContent))]
        [System.Xml.Serialization.XmlElementAttribute("footnote", typeof(StrucDocFootnote))]
        [System.Xml.Serialization.XmlElementAttribute("footnoteRef", typeof(StrucDocFootnoteRef))]
        [System.Xml.Serialization.XmlElementAttribute("linkHtml", typeof(StrucDocLinkHtml))]
        [System.Xml.Serialization.XmlElementAttribute("renderMultiMedia", typeof(StrucDocRenderMultiMedia))]
        [System.Xml.Serialization.XmlElementAttribute("sub", typeof(StrucDocSub))]
        [System.Xml.Serialization.XmlElementAttribute("sup", typeof(StrucDocSup))]
        public virtual object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
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
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public virtual string ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.RaisePropertyChanged("ID");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKEN")]
        public virtual string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
                this.RaisePropertyChanged("language");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
        public virtual string styleCode
        {
            get
            {
                return this.styleCodeField;
            }
            set
            {
                this.styleCodeField = value;
                this.RaisePropertyChanged("styleCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string abbr
        {
            get
            {
                return this.abbrField;
            }
            set
            {
                this.abbrField = value;
                this.RaisePropertyChanged("abbr");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string axis
        {
            get
            {
                return this.axisField;
            }
            set
            {
                this.axisField = value;
                this.RaisePropertyChanged("axis");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREFS")]
        public virtual string headers
        {
            get
            {
                return this.headersField;
            }
            set
            {
                this.headersField = value;
                this.RaisePropertyChanged("headers");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual StrucDocThScope scope
        {
            get
            {
                return this.scopeField;
            }
            set
            {
                this.scopeField = value;
                this.RaisePropertyChanged("scope");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool scopeSpecified
        {
            get
            {
                return this.scopeFieldSpecified;
            }
            set
            {
                this.scopeFieldSpecified = value;
                this.RaisePropertyChanged("scopeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public virtual string rowspan
        {
            get
            {
                return this.rowspanField;
            }
            set
            {
                this.rowspanField = value;
                this.RaisePropertyChanged("rowspan");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1")]
        public virtual string colspan
        {
            get
            {
                return this.colspanField;
            }
            set
            {
                this.colspanField = value;
                this.RaisePropertyChanged("colspan");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual StrucDocThAlign align
        {
            get
            {
                return this.alignField;
            }
            set
            {
                this.alignField = value;
                this.RaisePropertyChanged("align");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool alignSpecified
        {
            get
            {
                return this.alignFieldSpecified;
            }
            set
            {
                this.alignFieldSpecified = value;
                this.RaisePropertyChanged("alignSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string @char
        {
            get
            {
                return this.charField;
            }
            set
            {
                this.charField = value;
                this.RaisePropertyChanged("char");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string charoff
        {
            get
            {
                return this.charoffField;
            }
            set
            {
                this.charoffField = value;
                this.RaisePropertyChanged("charoff");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual StrucDocThValign valign
        {
            get
            {
                return this.valignField;
            }
            set
            {
                this.valignField = value;
                this.RaisePropertyChanged("valign");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public virtual bool valignSpecified
        {
            get
            {
                return this.valignFieldSpecified;
            }
            set
            {
                this.valignFieldSpecified = value;
                this.RaisePropertyChanged("valignSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
