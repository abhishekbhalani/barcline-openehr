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
    [Table("ConstraintBindingSet", Schema = "openehr")]
    public partial class ConstraintBindingSet : System.ComponentModel.INotifyPropertyChanged
    {
        
        private CONSTRAINT_BINDING_ITEMCollection itemsField;
        
        private string terminologyField;
        
        [System.Xml.Serialization.XmlElementAttribute("items")]
        [Barcline.Core.MinOccurs("0")]
        [Barcline.Core.MaxOccurs("unbounded")]
        public virtual CONSTRAINT_BINDING_ITEMCollection items
        {
            get
            {
                if (itemsField == null)
                {
                    this.itemsField = new CONSTRAINT_BINDING_ITEMCollection();
                }
                return itemsField;
            }
            set
            {
                this.itemsField = value;
                if (value != null)
                {
                }
                this.RaisePropertyChanged("items");
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [MaxLength(4000)]
        public virtual string terminology
        {
            get
            {
                return this.terminologyField;
            }
            set
            {
                this.terminologyField = value;
                this.RaisePropertyChanged("terminology");
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
