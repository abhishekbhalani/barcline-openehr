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
    /// <summary>
    /// Required properties: author, language
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("TRANSLATION_DETAILS", Schema = "openehr")]
    public partial class TRANSLATION_DETAILS : System.ComponentModel.INotifyPropertyChanged
    {
        
        private CODE_PHRASE languageField;
        
        private StringDictionaryItemCollection authorField;
        
        private string accreditationField;
        
        private StringDictionaryItemCollection other_detailsField;
        
        [Required()]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual CODE_PHRASE language
        {
            get
            {
                return languageField;
            }
            set
            {
                this.languageField = value;
                this.RaisePropertyChanged("language");
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("author")]
        [Barcline.Core.MinOccurs("1")]
        [Barcline.Core.MaxOccurs("unbounded")]
        [Required()]
        public virtual StringDictionaryItemCollection author
        {
            get
            {
                if (authorField == null)
                {
                    this.authorField = new StringDictionaryItemCollection();
                }
                return authorField;
            }
            set
            {
                this.authorField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("author");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [MaxLength(4000)]
        public virtual string accreditation
        {
            get
            {
                return this.accreditationField;
            }
            set
            {
                this.accreditationField = value;
                this.RaisePropertyChanged("accreditation");
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("other_details")]
        [Barcline.Core.MinOccurs("0")]
        [Barcline.Core.MaxOccurs("unbounded")]
        public virtual StringDictionaryItemCollection other_details
        {
            get
            {
                if (other_detailsField == null)
                {
                    this.other_detailsField = new StringDictionaryItemCollection();
                }
                return other_detailsField;
            }
            set
            {
                this.other_detailsField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("other_details");
            }
        }

        [field: NonSerialized]
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
