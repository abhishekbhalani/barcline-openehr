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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GLIST_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GLIST_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SLIST_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SLIST_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ON))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AD))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(II))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(POCD_MT000040InfrastructureRoottypeId))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CR))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CD))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BXIT_CD))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_CD))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HXIT_CE))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EIVLevent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CV))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PQR))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QTY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RTO_MO_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RTO_PQ_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RTO_QTY_QTY))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RTO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_MO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_MO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_MO))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(REAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_REAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_REAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_REAL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(INT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(POCD_MT000040RegionOfInterestvalue))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_INT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_INT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_INT))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HXIT_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_PPD_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BXIT_IVL_PQ))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UVP_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EIVL_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PIVL_PPD_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVXB_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXCM_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SXPR_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EIVL_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PIVL_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(IVL_TS))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(URL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TEL))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BIN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ED))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ST))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ENXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ensuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enprefix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(engiven))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(enfamily))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(endelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ADXP))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpprecinct))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxppostBox))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpbuildingNumberSuffix))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryModeIdentifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryMode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationQualifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationArea))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryInstallationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdeliveryAddressLine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcensusTract))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcareOf))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpunitType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpunitID))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpadditionalLocator))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetNameType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetNameBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetName))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdirection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxphouseNumberNumeric))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxphouseNumber))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstreetAddressLine))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxppostalCode))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcounty))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpstate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpcountry))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(adxpdelimiter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SC))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(thumbnail))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ANYNonNull))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BN))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BL))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XsdShell", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:hl7-org:v3")]
    public abstract partial class ANY : CdaObject, System.ComponentModel.INotifyPropertyChanged
    {
        
        private string nullFlavorField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public virtual string nullFlavor
        {
            get
            {
                return this.nullFlavorField;
            }
            set
            {
                this.nullFlavorField = value;
                this.RaisePropertyChanged("nullFlavor");
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
