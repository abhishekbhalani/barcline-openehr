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
    [Table("EXTRACT_CHAPTER", Schema = "openehr")]
    public partial class EXTRACT_CHAPTER : LOCATABLE
    {
        
        private EXTRACT_FOLDER directoryField;
        
        private EXTRACT_CONTENT contentField;
        
        private EXTRACT_ENTITY_IDENTIFIER entity_identifierField;
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual EXTRACT_FOLDER directory
        {
            get
            {
                return directoryField;
            }
            set
            {
                this.directoryField = value;
                this.RaisePropertyChanged("directory");
            }
        }
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual EXTRACT_CONTENT content
        {
            get
            {
                return contentField;
            }
            set
            {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }
        
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual EXTRACT_ENTITY_IDENTIFIER entity_identifier
        {
            get
            {
                return entity_identifierField;
            }
            set
            {
                this.entity_identifierField = value;
                this.RaisePropertyChanged("entity_identifier");
            }
        }
    }
}
