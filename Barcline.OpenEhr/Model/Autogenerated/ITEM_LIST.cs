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
    [Table("ITEM_LIST", Schema = "openehr")]
    public partial class ITEM_LIST : ITEM_STRUCTURE
    {
        
        private ELEMENTCollection itemsField;
        
        [System.Xml.Serialization.XmlElementAttribute("items")]
        public virtual ELEMENTCollection items
        {
            get
            {
                if (itemsField == null)
                {
                    this.itemsField = new ELEMENTCollection();
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
    }
}