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
    /// Required properties: items
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("ARCHETYPE_TERM", Schema = "openehr")]
    public partial class ARCHETYPE_TERM : System.ComponentModel.INotifyPropertyChanged
    {
        
        private StringDictionaryItemCollection itemsField;
        
        private string codeField;
        
        [System.Xml.Serialization.XmlElementAttribute("items")]
        [Barcline.Core.MaxOccurs("unbounded")]
        [Required()]
        public virtual StringDictionaryItemCollection items
        {
            get
            {
                if (itemsField == null)
                {
                    this.itemsField = new StringDictionaryItemCollection();
                }
                return itemsField;
            }
            set
            {
                this.itemsField = value;
                this.RaisePropertyChanged("items");
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [MaxLength(4000)]
        public virtual string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
                this.RaisePropertyChanged("code");
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
