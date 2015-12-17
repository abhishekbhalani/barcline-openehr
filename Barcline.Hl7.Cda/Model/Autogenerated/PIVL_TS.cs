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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    public partial class PIVL_TS : SXCM_TS
    {
        
        private IVL_TS phaseField;
        
        private PQ periodField;
        
        private string alignmentField;
        
        private bool institutionSpecified1Field;
        
        public PIVL_TS()
        {
            this.institutionSpecified1Field = false;
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual IVL_TS phase
        {
            get
            {
                return phaseField;
            }
            set
            {
                this.phaseField = value;
                this.RaisePropertyChanged("phase");
            }
        }
        
        /// <remarks/>
        [System.ComponentModel.TypeConverter(typeof(System.ComponentModel.ExpandableObjectConverter))]
        public virtual PQ period
        {
            get
            {
                return periodField;
            }
            set
            {
                this.periodField = value;
                this.RaisePropertyChanged("period");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string alignment
        {
            get
            {
                return this.alignmentField;
            }
            set
            {
                this.alignmentField = value;
                this.RaisePropertyChanged("alignment");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("institutionSpecified")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public virtual bool institutionSpecified1
        {
            get
            {
                return this.institutionSpecified1Field;
            }
            set
            {
                this.institutionSpecified1Field = value;
                this.RaisePropertyChanged("institutionSpecified1");
            }
        }
    }
}
