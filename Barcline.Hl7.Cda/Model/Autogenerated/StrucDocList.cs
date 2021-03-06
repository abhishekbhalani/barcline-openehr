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
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="StrucDoc.List", Namespace="urn:hl7-org:v3")]
    public partial class StrucDocList : CdaObject, System.ComponentModel.INotifyPropertyChanged
    {
        
        private StrucDocCaption captionField;
        
        private StrucDocItemCollection itemField;
        
        private string idField;
        
        private string languageField;
        
        private string styleCodeField;
        
        private StrucDocListListType listTypeField;
        
        public StrucDocList()
        {
            this.listTypeField = StrucDocListListType.unordered;
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual StrucDocCaption caption
        {
            get
            {
                return captionField;
            }
            set
            {
                this.captionField = value;
                this.RaisePropertyChanged("caption");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public virtual StrucDocItemCollection item
        {
            get
            {
                if (itemField == null)
                {
                    this.itemField = new StrucDocItemCollection();
                }
                return itemField;
            }
            set
            {
                this.itemField = value;
                this.RaisePropertyChanged("item");
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
        [System.ComponentModel.DefaultValueAttribute(StrucDocListListType.unordered)]
        public virtual StrucDocListListType listType
        {
            get
            {
                return this.listTypeField;
            }
            set
            {
                this.listTypeField = value;
                this.RaisePropertyChanged("listType");
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
