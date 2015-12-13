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
    /// Required properties: original_language
    /// </summary>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ARCHETYPE))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("AUTHORED_RESOURCE", Schema = "openehr")]
    public partial class AUTHORED_RESOURCE : System.ComponentModel.INotifyPropertyChanged
    {
        
        private CODE_PHRASE original_languageField;
        
        private bool? is_controlledField;
        
        private bool is_controlledFieldSpecified;
        
        private RESOURCE_DESCRIPTION descriptionField;
        
        private TRANSLATION_DETAILSCollection translationsField;
        
        private REVISION_HISTORY_ITEMCollection revision_historyField;
        
        [Required()]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual CODE_PHRASE original_language
        {
            get
            {
                return original_languageField;
            }
            set
            {
                this.original_languageField = value;
                this.RaisePropertyChanged("original_language");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        public virtual bool? is_controlled
        {
            get
            {
                return this.is_controlledField;
            }
            set
            {
                this.is_controlledField = value;
                this.RaisePropertyChanged("is_controlled");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [NotMapped]
        public virtual bool is_controlledSpecified
        {
            get
            {
                return this.is_controlledFieldSpecified;
            }
            set
            {
                this.is_controlledFieldSpecified = value;
                this.RaisePropertyChanged("is_controlledSpecified");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual RESOURCE_DESCRIPTION description
        {
            get
            {
                return descriptionField;
            }
            set
            {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("translations")]
        [Barcline.Core.MinOccurs("0")]
        [Barcline.Core.MaxOccurs("unbounded")]
        public virtual TRANSLATION_DETAILSCollection translations
        {
            get
            {
                if (translationsField == null)
                {
                    this.translationsField = new TRANSLATION_DETAILSCollection();
                }
                return translationsField;
            }
            set
            {
                this.translationsField = value;
                this.RaisePropertyChanged("translations");
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("items", IsNullable=false)]
        [Barcline.Core.MinOccurs("0")]
        public virtual REVISION_HISTORY_ITEMCollection revision_history
        {
            get
            {
                if (revision_historyField == null)
                {
                    this.revision_historyField = new REVISION_HISTORY_ITEMCollection();
                }
                return revision_historyField;
            }
            set
            {
                this.revision_historyField = value;
                this.RaisePropertyChanged("revision_history");
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
