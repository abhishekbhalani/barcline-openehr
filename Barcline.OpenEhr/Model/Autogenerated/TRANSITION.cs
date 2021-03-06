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
    /// Required properties: event
    /// </summary>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.openehr.org/v1")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.openehr.org/v1", IsNullable=true)]
    [Table("TRANSITION", Schema = "openehr")]
    public partial class TRANSITION : System.ComponentModel.INotifyPropertyChanged
    {
        
        private string eventField;
        
        private string actionField;
        
        private string guardField;
        
        private STATE next_stateField;
        
        [Required()]
        [MaxLength(4000)]
        public virtual string @event
        {
            get
            {
                return this.eventField;
            }
            set
            {
                this.eventField = value;
                this.RaisePropertyChanged("event");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [MaxLength(4000)]
        public virtual string action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
                this.RaisePropertyChanged("action");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [MaxLength(4000)]
        public virtual string guard
        {
            get
            {
                return this.guardField;
            }
            set
            {
                this.guardField = value;
                this.RaisePropertyChanged("guard");
            }
        }
        
        [Barcline.Core.MinOccurs("0")]
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual STATE next_state
        {
            get
            {
                return next_stateField;
            }
            set
            {
                this.next_stateField = value;
                this.RaisePropertyChanged("next_state");
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
